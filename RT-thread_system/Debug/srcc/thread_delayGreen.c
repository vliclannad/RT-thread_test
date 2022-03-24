#include "includes.h"

//======================================================================
//函数名称：thread_greenlight
//函数返回：无
//参数说明：无
//功能概要：每2秒绿灯反转
//内部调用：无
//======================================================================
void thread_delayGreen(void)
{
    userprintf("------第一次进入绿灯线程：%x。\r\n",thread_self());
    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
    while (1)
    {
    	userprintf("2-1.当前运行的线程=%x，绿灯延时10秒（开始）；\r\n",thread_self());
		delay_ms(10000);  //延时
		userprintf("2-2.当前运行的线程=%x，绿灯延时10秒（结束），绿灯反转。\r\n",thread_self());
		gpio_reverse(LIGHT_GREEN);    //灯的状态反转
    }
}
