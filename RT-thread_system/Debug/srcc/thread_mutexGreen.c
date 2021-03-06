#include "includes.h"

//======================================================================
//函数名称：thread_mutexGreen
//函数返回：无
//参数说明：无
//功能概要：每10秒绿灯反转
//内部调用：无
//======================================================================
void thread_mutexGreen()
{
     //（1）======申明局部变量==========================================
    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
    uart_send_string(UART_User,(void *)"第一次进入绿灯线程！\r\n");
    //（2）======主循环（开始）==========================================
    while (1)
    {
    	//1.锁住单色灯互斥量
    	rt_mutex_take(mutex,RT_WAITING_FOREVER);
    	uart_send_string(UART_User,(void *)"\r\n锁定单色互斥量成功！绿灯反转，延时10秒\r\n");
        //2.绿灯变亮
        gpio_reverse(LIGHT_GREEN);
        //3.延时10秒
        delay_ms(10000);
    	//4.绿灯变暗
    	gpio_reverse(LIGHT_GREEN);
    	//5.解锁单色灯互斥量
		rt_mutex_release(mutex);
    }//（2）======主循环（结束）==========================================
}
