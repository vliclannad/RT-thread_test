//=====================================================================
//文件名称：isr.c（中断处理程序源文件）
//框架提供：SD-ARM（sumcu.suda.edu.cn）
//版本更新：20170801-20191020
//功能描述：提供中断处理程序编程框架
//移植规则：【固定】
//=====================================================================
#include "includes.h"

static uint8_t emuartFrameHead[2] = {0xA5,0x5A};  //帧头
uint16_t useremuart_frame(uint8_t ch, uint8_t *data);

//======================================================================
//程序名称：UART_User_Handler
//触发条件：UART_User串口收到一个字节触发
//备    注：进入本程序后，可使用uart_get_re_int函数可再进行中断标志判断
//          （1-有UART接收中断，0-没有UART接收中断）
//======================================================================
void UART_User_Handler(void)
{
	 //（1）变量声明
    uint8_t flag,ch;
    DISABLE_INTERRUPTS;      //关总中断
    //（2）未触发串口接收中断，退出
    if(!uart_get_re_int(UART_User)) goto UART_User_Handler_EXIT;
    //（3）收到一个字节，读出该字节数据
    ch = uart_re1(UART_User,&flag);        //调用接收一个字节的函数
    if(!flag) goto UART_User_Handler_EXIT; //实际未收到数据，退出

    
       gcRecvLen =useremuart_frame(ch,(uint8_t*)gcRecvBuf);//对接收数据组帧，返回0组帧未成功，返回长度组帧成功。
       if (gcRecvLen == 0) goto UART_User_Handler_EXIT; 
       rt_event_send(EventWord,RULE_CHOOSE_EVENT);//数据接收完成，对命令选择事件置位
        gcRecvLen = 0;   //帧已经使用完毕，下次若收到一个字节，可以继续组帧
        //【使用模板提供的User串口通信帧结构（结束)】
     
    //（5）【公共退出区】
UART_User_Handler_EXIT:{
	//printf("goto----1\n");
    ENABLE_INTERRUPTS;
    }
    //main_Dly_ms(10);//开总中断
}

//===========================================================================
//函数名称：useremuart_frame
//功能概要：组帧，将待组帧的数据加入帧中。本函数应被放置于中断处理程序中。
//参数说明：ch：串口接收到一个字节数据；数组data：存放接收到的数据。
//函数返回：0：未组帧成功；非0：组帧成功，且返回值为接收到的数据长度
//备注：十六进制数据帧格式
//      帧头 + 数据长度 + 有效数据 
//      emuartFrameHead(2字节)
//      len(1字节)
//      有效数据(N字节 N=len[0]*256+len[1])
//===========================================================================
uint16_t useremuart_frame(uint8_t ch, uint8_t *data)
{
	//printf("进入到emuart_frame中开始组帧\n");
	static uint16_t index = 1;
	static uint16_t length = 1;
	uint16_t ret_val;
	
	
	//（1）若未接收到数据或者未遇到帧头，则退出并返回0  帧头长度为两个字节
	if(((index-1) == 0 && ch != emuartFrameHead[0]) ||
			((index-1) == 1 && ch != emuartFrameHead[1]))
	{
		index = 1;
		length = 1;
		ret_val = 0;     //接收数据错误
		goto uecom_recv_exit;
	}
	//（2）正确接收到了帧头，继续执行，将数据存入data数组
	data[(index++)-1] = ch;
	//printf("%d",index);
	//（3）当获取到第四个数据时，求出有效数据长度


	if((index-1) == 3)
	{
		//printf("长度正确赋予\n");
		length = data[2];
	}
	//判断数据是否接收完毕，接收完毕退出组帧
	if(index==data[2]+4)
	{
		index = 1;
		ret_val = (length+3); //返回有效数据长度
		length=1;
		//data[(length-1)] = 0; //令数组长度为0
		goto uecom_recv_exit;
	}
	ret_val = 0;
	goto uecom_recv_exit;
uecom_recv_exit:
    return ret_val;
}