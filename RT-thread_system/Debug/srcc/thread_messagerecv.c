#include "includes.h"

//======================================================================
//函数名称：thread_messagerecv
//函数返回：无
//参数说明：无
//功能概要：如果队列中有消息，则打印出相关的相应的消息，并此时消息队列中消息的个数
//内部调用：无
//======================================================================
void thread_messagerecv()
{
	//（1）======申明局部变量==========================================
    uint8_t temp[8];
	char *cnt;
	uint8_t recvState;
	printf("第一次进入消息接收线程!\r\n");
	gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);
	 //（2）======主循环（开始）==========================================
    while (1)
    {
	    //等待消息
		recvState=mq_recv(mq,&temp,sizeof(temp),RT_WAITING_FOREVER);

		if(recvState==0)  //若获得消息
       	{
			cnt = rt_malloc(1);//申请内存  
    	   	rt_sprintf(cnt,"%d",mq->entry);//entry队列中的消息索引
    	   	uart_send_string(UART_User,(void*)"消息队列中消息数=");
    	   	uart_send_string(UART_User,(uint8_t *)cnt);
    	   	uart_send_string(UART_User,(void *) "\r\n");
    	   	uart_send_string(UART_User,(void*) "当前取出的消息=");
    	   	uart_sendN(UART_User,8,temp);
    	   	uart_send_string(UART_User,(void *) "\r\n");
    	   	delay_ms(1000);                //延迟，为了演示消息堆积的情况


			useruart_send_string(UART_User,(void*)"消息消息消息消息消息消息消息消息");
    	 }
    }//（2）======主循环（结束）==========================================
}
