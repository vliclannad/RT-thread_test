#include "includes.h"

//======================================================================
//函数名称：rule_choose
//函数返回：无
//参数说明：无
//功能概要：根据接收到的命令，启动/挂起对应的线程
//内部调用：无
//======================================================================

void thread_rulechoose()
{
        uint32_t recvedstate;
    while(1)
    {
        printf("进入命令选择线程，等待事件信号/n");
        rt_event_recv(EventWord,RULE_CHOOSE_EVENT,RT_EVENT_FLAG_OR|RT_EVENT_FLAG_CLEAR,RT_WAITING_FOREVER,&recvedstate);//等待命令选择线程的事件信号，串口接收完数据后会触发
        if(recvedstate==RULE_CHOOSE_EVENT)  //如果接收完成且正确
    	{
    		if(gcRecvBuf[3]==0x90) //命令字为90，代表“事件功能”
            {
                if(gcRecvBuf[4]==0x01)//命令参数为01，代表启动该功能，传递事件信号把小灯线程从阻塞队列移到就绪队列
                {
                    grt_flag=1;
                    rt_event_send(EventWord,BLUE_LIGHT_EVENT);
                }
                if(gcRecvBuf[4]==0x00)//命令参数为00，代表关闭该功能，重新启动小灯线程，把小灯线程移入阻塞队列
                {
                    grt_flag=0;

                }
                

            }

            if(gcRecvBuf[3]==0x91) //命令字为91，代表“消息队列功能”
            {

            }

            if(gcRecvBuf[3]==0x92) //命令字为90，代表“信号量功能”
            {

            }

            if(gcRecvBuf[3]==0x93) //命令字为90，代表“互斥量功能”
            {

            }

    	}
    }
}
