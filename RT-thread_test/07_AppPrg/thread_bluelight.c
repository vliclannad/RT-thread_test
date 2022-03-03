#include "includes.h"

//======================================================================
//函数名称：thread_bluelight
//函数返回：无
//参数说明：无
//功能概要：蓝灯线程中，每10秒设置绿灯事件
//内部调用：无
//======================================================================
void thread_bluelight()
{
    //（1）======申明局部变量==========================================
    uint32_t recvedstate;

    printf("---第一次进入运行蓝灯线程!\r\n");
    gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
    

    //（2）======主循环（开始）==========================================
    while (1)   //主循环
    {
      rt_event_recv(EventWord,BLUE_LIGHT_EVENT,RT_EVENT_FLAG_OR|RT_EVENT_FLAG_CLEAR,RT_WAITING_FOREVER,&recvedstate);//等待接收蓝灯事件信号
      if(recvedstate==GREEN_LIGHT_EVENT)
     {  //如果接收完成且正确
    	uart_send_string(UART_User,(void *)"----进入蓝灯线程-----\r\n");
    	uart_send_string(UART_User,(void *)"在蓝灯线程中，设置绿灯事件\r\n");
    	//设置GREEN_LIGHT_EVENT事件位
	  	rt_event_send(EventWord,GREEN_LIGHT_EVENT);
    	uart_send_string(UART_User,(void *)"------蓝灯闪烁------\r\n");
	  	gpio_reverse(LIGHT_BLUE);
		  delay_ms(10000);
     }
    }//（2）======主循环（结束）==========================================
}
