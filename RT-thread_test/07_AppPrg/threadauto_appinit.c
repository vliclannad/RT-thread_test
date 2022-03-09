#include "includes.h"
//======================================================================
//�������ƣ�app_init
//�������أ���
//����˵������
//���ܸ�Ҫ�����̣߳�Ҫ���ȫ�ֱ�����ʼ���������ʼ�������������û��̡߳������û��̵߳ȹ���
//�ڲ����ã���
//======================================================================

void app_init(void)
{
	//��1��======�������֣���ͷ��==========================================
	//��1.1������main����ʹ�õľֲ�����
	rt_thread_t thd_rulechoose;
 	rt_thread_t thd_greenlight;
 	rt_thread_t thd_bluelight;
 	rt_thread_t thd_messagerecv;
 	rt_thread_t thd_SPThread1;
 	rt_thread_t thd_SPThread2;
 	rt_thread_t thd_SPThread3;
	int SPcount;

	
	//��1.2�������䡿BIOS��API�ӿڱ��׵�ַ���û��жϴ����������ʼ��
	//��1.3�������䡿�����ж�
	DISABLE_INTERRUPTS;

	//��1.4����������ʹ�õľֲ���������ֵ

	//��1.5����ȫ�ֱ�������ֵ
	grt_flag=1;

	//��1.6���û�����ģ���ʼ��
	printf("  ����gpio_init�������ֱ��ʼ����ơ��̵ơ�����\r\n");
	gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
	gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
	uart_init(UART_User,115200); 
	//��1.7��ʹ��ģ���ж�
	uart_enable_re_int(UART_User);
	//��1.8�������䡿�����ж�
	ENABLE_INTERRUPTS;
	printf("�����«��ʾ��������Ϊ��RT-Thread��STM32�û�����\r\n");
	printf("���������ܡ����� RT-Thread�����󴴽��˺�ơ��̵ƺ����������û��߳�\r\n");
	printf("	        ��ʵ������ÿ10����˸һ��,�������¼���\r\n");
	printf("	        ���̵��̵߳ȴ����¼��֣�ת���̵�״̬\r\n");
	printf("���������������Ӵ���User��ѡ������Ϊ115200���򿪴��ڣ��鿴������...\r\r\n\n");
	printf("0-1.MCU����\n");
	
	//�����¼���
	EventWord=rt_event_create("EventWord",RT_IPC_FLAG_PRIO);
	//������Ϣ����
	mq=rt_mq_create("mq",9,4,RT_IPC_FLAG_FIFO);
	//�����ź���
	SP=rt_sem_create("SP",0,RT_IPC_FLAG_FIFO);
	SPcount=SP->value;
	printf("��ǰSPΪ%d\n",SPcount);


	//��������ѡ���߳�
	thd_rulechoose=rt_thread_create("rulechoose", (void *)thread_rulechoose, 0, 512, 9, 10);
	//������ɫ���߳�
	thd_greenlight = rt_thread_create("greenlight", (void *)thread_greenlight, 0, 512, 10, 10);
	thd_bluelight = rt_thread_create("bluelight", (void *)thread_bluelight, 0, 512, 10, 10);
	//������Ϣ�����߳�
	thd_messagerecv = rt_thread_create("messagerecv", (void *)thread_messagerecv, 0, 512, 10, 10);
	//���������ź����߳�
	thd_SPThread1 = rt_thread_create("SPThread1", (void *)thread_SPThread1, 0, 512, 10, 10);
	thd_SPThread2 = rt_thread_create("SPThread2", (void *)thread_SPThread2, 0, 512, 10, 10);
	thd_SPThread3 = rt_thread_create("SPThread3", (void *)thread_SPThread3, 0, 512, 10, 10);

	   
	rt_thread_startup(thd_greenlight);//�����̵��߳�
	rt_thread_startup(thd_bluelight);//���������߳�
	rt_thread_startup(thd_messagerecv);//������Ϣ�����߳�
	rt_thread_startup(thd_SPThread1);//�����ź����߳�1
	rt_thread_startup(thd_SPThread2);//�����ź����߳�2
	rt_thread_startup(thd_SPThread3);//�����ź����߳�3

    rt_thread_startup(thd_rulechoose);//��������ѡ���߳�
}
