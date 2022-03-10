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
        uint8_t recvData[9];
    while(1)
    {
        printf("进入命令选择线程，等待事件信号\n");
        rt_event_recv(EventWord,RULE_CHOOSE_EVENT,RT_EVENT_FLAG_OR|RT_EVENT_FLAG_CLEAR,RT_WAITING_FOREVER,&recvedstate);//等待命令选择线程的事件信号，串口接收完数据后会触发
        printf("接收到事件信号\n");
        if(recvedstate==RULE_CHOOSE_EVENT)  //如果接收完成且正确
    	{
    		if(gcRecvBuf[7]==EVENT_CODE) //命令字为90，代表“事件功能”
            {
                if(gcRecvBuf[8]==0x01)//命令参数为01，代表启动该功能，传递事件信号把小灯线程从阻塞队列移到就绪队列
                {  
                    //启动该功能线程前先关闭其他功能线程
                    rt_thread_detach(thd_messagerecv);
                    rt_thread_detach(thd_SPThread1);	
                    rt_thread_detach(thd_SPThread2);
                    rt_thread_detach(thd_SPThread3);
                    rt_thread_detach(thd_mutexRed);
                    rt_thread_detach(thd_mutexGreen);
                    rt_thread_detach(thd_mutexBlue);


                    rt_thread_startup(thd_bluelight);
                    rt_thread_startup(thd_greenlight);
                    rt_event_send(EventWord,BLUE_LIGHT_EVENT);

                }
                if(gcRecvBuf[8]==0x00)//命令参数为00，代表关闭该功能，重新启动小灯线程，把小灯线程移入阻塞队列
                {
                    printf("接收到事件功能结束命令，事件功能模块结束");
                    rt_thread_detach(thd_bluelight);
                    rt_thread_detach(thd_greenlight);
                    gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);
                }
                

            }

            if(gcRecvBuf[7]==MESSAGE_CODE) //命令字为91，代表“消息队列功能”
            {
                rt_thread_detach(thd_bluelight);
                rt_thread_detach(thd_greenlight);
                rt_thread_detach(thd_SPThread1);	
                rt_thread_detach(thd_SPThread2);
                rt_thread_detach(thd_SPThread3);
                rt_thread_detach(thd_mutexRed);
                rt_thread_detach(thd_mutexGreen);
                rt_thread_detach(thd_mutexBlue);


                rt_thread_startup(thd_messagerecv);//启动消息队列线程
                //取出收到的数据作为一个消息
			    for(int i=0;i<8;i++)
				recvData[i] = gcRecvBuf[i+9];
		        //将该消息存放到消息队列
			    rt_mq_send(mq,recvData,sizeof(recvData));
		    }

            

            if(gcRecvBuf[7]==SEM_CODE) //命令字为90，代表“信号量功能”
            {
                if(gcRecvBuf[8]==0x01)//命令参数为01，代表启动该功能
                {
                    printf("接收到信号量功能开启命令，信号量功能模块开启\n");
                    rt_thread_detach(thd_bluelight);
                    rt_thread_detach(thd_greenlight);
                    rt_thread_detach(thd_messagerecv);
                    rt_thread_detach(thd_mutexRed);
                    rt_thread_detach(thd_mutexGreen);
                    rt_thread_detach(thd_mutexBlue);



	                rt_thread_startup(thd_SPThread1);//启动信号量线程1
	                rt_thread_startup(thd_SPThread2);//启动信号量线程2
	                rt_thread_startup(thd_SPThread3);//启动信号量线程


                }
                if(gcRecvBuf[8]==0x00)//命令参数为00，代表关闭该功能
                {
                    printf("接收到信号量功能结束命令，信号量功能模块结束");
                    rt_thread_detach(thd_SPThread1);	
                    rt_thread_detach(thd_SPThread2);
                    rt_thread_detach(thd_SPThread3);
                    gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);

                }

            }

            if(gcRecvBuf[7]==MUTEX_CODE) //命令字为90，代表“互斥量功能”
            {
                if(gcRecvBuf[8]==0x01)
                {
                    printf("接收到互斥量功能开启命令，互斥量功能模块开启\n");
                    rt_thread_detach(thd_bluelight);
                    rt_thread_detach(thd_greenlight);
                    rt_thread_detach(thd_messagerecv);
                    rt_thread_detach(thd_SPThread1);	
                    rt_thread_detach(thd_SPThread2);
                    rt_thread_detach(thd_SPThread3);

                    rt_thread_startup(thd_mutexRed);//启动红灯线程
	                rt_thread_startup(thd_mutexGreen);//启动绿灯线程
	                rt_thread_startup(thd_mutexBlue);//启动蓝灯线程
                }
                if(gcRecvBuf[8]==0x00)
                {
                    printf("接收到互斥量功能关闭命令，互斥量功能模块关闭\n");
                    rt_thread_detach(thd_mutexRed);
                    rt_thread_detach(thd_mutexGreen);
                    rt_thread_detach(thd_mutexBlue);
                    gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);
                }

            }

    	}
    }
}
