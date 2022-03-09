#include "includes.h"
//======================================================================
//函数名称：app_init
//函数返回：无
//参数说明：无
//功能概要：主线程，要完成全局变量初始化、外设初始化、创建其他用户线程、启动用户线程等工作
//内部调用：无
//======================================================================

void app_init(void)
{
	//（1）======启动部分（开头）==========================================
	//（1.1）声明main函数使用的局部变量
	rt_thread_t thd_rulechoose;
 	rt_thread_t thd_greenlight;
 	rt_thread_t thd_bluelight;
 	rt_thread_t thd_messagerecv;
 	rt_thread_t thd_SPThread1;
 	rt_thread_t thd_SPThread2;
 	rt_thread_t thd_SPThread3;
	int SPcount;

	
	//（1.2）【不变】BIOS中API接口表首地址、用户中断处理程序名初始化
	//（1.3）【不变】关总中断
	DISABLE_INTERRUPTS;

	//（1.4）给主函数使用的局部变量赋初值

	//（1.5）给全局变量赋初值
	grt_flag=1;

	//（1.6）用户外设模块初始化
	printf("  调用gpio_init函数，分别初始化红灯、绿灯、蓝灯\r\n");
	gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
	gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
	uart_init(UART_User,115200); 
	//（1.7）使能模块中断
	uart_enable_re_int(UART_User);
	//（1.8）【不变】开总中断
	ENABLE_INTERRUPTS;
	printf("【金葫芦提示】本程序为带RT-Thread的STM32用户程序\r\n");
	printf("【基本功能】①在 RT-Thread启动后创建了红灯、绿灯和蓝灯三个用户线程\r\n");
	printf("	        ②实现蓝灯每10秒闪烁一次,并设置事件字\r\n");
	printf("	        ③绿灯线程等待到事件字，转换绿灯状态\r\n");
	printf("【操作方法】连接串口User，选择波特率为115200，打开串口，查看输出结果...\r\r\n\n");
	printf("0-1.MCU启动\n");
	
	//创建事件字
	EventWord=rt_event_create("EventWord",RT_IPC_FLAG_PRIO);
	//创建消息队列
	mq=rt_mq_create("mq",9,4,RT_IPC_FLAG_FIFO);
	//创建信号量
	SP=rt_sem_create("SP",0,RT_IPC_FLAG_FIFO);
	SPcount=SP->value;
	printf("当前SP为%d\n",SPcount);


	//创建命令选择线程
	thd_rulechoose=rt_thread_create("rulechoose", (void *)thread_rulechoose, 0, 512, 9, 10);
	//创建三色灯线程
	thd_greenlight = rt_thread_create("greenlight", (void *)thread_greenlight, 0, 512, 10, 10);
	thd_bluelight = rt_thread_create("bluelight", (void *)thread_bluelight, 0, 512, 10, 10);
	//创建消息队列线程
	thd_messagerecv = rt_thread_create("messagerecv", (void *)thread_messagerecv, 0, 512, 10, 10);
	//创建三个信号量线程
	thd_SPThread1 = rt_thread_create("SPThread1", (void *)thread_SPThread1, 0, 512, 10, 10);
	thd_SPThread2 = rt_thread_create("SPThread2", (void *)thread_SPThread2, 0, 512, 10, 10);
	thd_SPThread3 = rt_thread_create("SPThread3", (void *)thread_SPThread3, 0, 512, 10, 10);

	   
	rt_thread_startup(thd_greenlight);//启动绿灯线程
	rt_thread_startup(thd_bluelight);//启动蓝灯线程
	rt_thread_startup(thd_messagerecv);//启动消息队列线程
	rt_thread_startup(thd_SPThread1);//启动信号量线程1
	rt_thread_startup(thd_SPThread2);//启动信号量线程2
	rt_thread_startup(thd_SPThread3);//启动信号量线程3

    rt_thread_startup(thd_rulechoose);//启动命令选择线程
}
