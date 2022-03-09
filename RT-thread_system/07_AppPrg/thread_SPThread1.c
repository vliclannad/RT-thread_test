#include "includes.h"

//======================================================================
//函数名称：thread_SPThread1
//函数返回：无
//参数说明：无
//功能概要：抢夺信号量
//内部调用：无
//======================================================================
void thread_SPThread1()
{

    //（1）======申明局部变量===========================================
    int SPcount;      //记录信号量的个数
    printf("第一次进入线程1！\n");
	gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);
    //（2）======主循环（开始）==========================================
    while (1)
    {
    	delay_ms(1000);    //延时1秒
    	SPcount=SP->value;  //获取信号量的值
    	printf("当前SP为%d\n",SPcount);
    	printf("线程1请求1个SP\n");
		if(SPcount==0)
		{
			printf("SP为0，线程1等待\n");
		}
		//获取一个信号量
		rt_sem_take(SP,RT_WAITING_FOREVER);
		SPcount=SP->value;
		printf("线程1获取1个SP，SP还剩%d\n",SPcount);
		delay_ms(5000);
		//释放一个信号量
		rt_sem_release(SP);
        printf("线程1成功释放1个SP\n");
	}//（2）======主循环（结束）==========================================
	
}
