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
        rt_event_recv(EventWord,RULE_CHOOSE_EVENT,RT_EVENT_FLAG_OR|RT_EVENT_FLAG_CLEAR,RT_WAITING_FOREVER,&recvedstate);
        if(recvedstate==RULE_CHOOSE_EVENT)  //如果接收完成且正确
    	{
    		if(gcRecvBuf[3]==0x90) //命令字为90，代表“事件功能”
            {
                rt_event_send(EventWord,BLUE_LIGHT_EVENT);

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