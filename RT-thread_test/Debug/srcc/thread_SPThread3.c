#include "includes.h"

//======================================================================
//�������ƣ�thread_SPThread3
//�������أ���
//����˵������
//���ܸ�Ҫ�������ź���
//�ڲ����ã���
//======================================================================
void thread_SPThread3()
{
    //��1��======�����ֲ�����===========================================
    int SPcount;      //��¼�ź����ĸ���
    printf("��һ�ν����߳�3��\n");
	gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);
    //��2��======��ѭ������ʼ��==========================================
    while (1)
    {
		gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
    	delay_ms(1000);    //��ʱ1��
    	SPcount=SP->value; //��ȡ�ź�����ֵ
    	printf("��ǰSP����Ϊ%d\n",SPcount);
    	printf("�߳�3����1��SP\n");
		if(SPcount==0)
		{
			printf("SP����Ϊ0���߳�3�ȴ�\n");

		}
		rt_sem_take(SP,RT_WAITING_FOREVER); //��ȡһ���ź���
		SPcount=SP->value;                 //��ȡ�ź�����ֵ
		printf("�߳�3��ȡ1��SP��SP��ʣ%d\n",SPcount);
		delay_ms(3000);
	    printf("ת�����״̬\n");
		gpio_reverse(LIGHT_RED);
		rt_sem_release(SP);   //�ͷ�һ���ź���
		printf("�߳�3�ɹ��ͷ�1��SP\n");
    }//��2��======��ѭ����������==========================================  
}
