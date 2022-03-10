#include "includes.h"

//======================================================================
//�������ƣ�rule_choose
//�������أ���
//����˵������
//���ܸ�Ҫ�����ݽ��յ����������/�����Ӧ���߳�
//�ڲ����ã���
//======================================================================

void thread_rulechoose()
{
        uint32_t recvedstate;
        uint8_t recvData[9];
    while(1)
    {
        printf("��������ѡ���̣߳��ȴ��¼��ź�\n");
        rt_event_recv(EventWord,RULE_CHOOSE_EVENT,RT_EVENT_FLAG_OR|RT_EVENT_FLAG_CLEAR,RT_WAITING_FOREVER,&recvedstate);//�ȴ�����ѡ���̵߳��¼��źţ����ڽ��������ݺ�ᴥ��
        printf("���յ��¼��ź�\n");
        if(recvedstate==RULE_CHOOSE_EVENT)  //��������������ȷ
    	{
    		if(gcRecvBuf[7]==EVENT_CODE) //������Ϊ90�������¼����ܡ�
            {
                if(gcRecvBuf[8]==0x01)//�������Ϊ01�����������ù��ܣ������¼��źŰ�С���̴߳����������Ƶ���������
                {  
                    //�����ù����߳�ǰ�ȹر����������߳�
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
                if(gcRecvBuf[8]==0x00)//�������Ϊ00������رոù��ܣ���������С���̣߳���С���߳�������������
                {
                    printf("���յ��¼����ܽ�������¼�����ģ�����");
                    rt_thread_detach(thd_bluelight);
                    rt_thread_detach(thd_greenlight);
                    gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);
                }
                

            }

            if(gcRecvBuf[7]==MESSAGE_CODE) //������Ϊ91��������Ϣ���й��ܡ�
            {
                rt_thread_detach(thd_bluelight);
                rt_thread_detach(thd_greenlight);
                rt_thread_detach(thd_SPThread1);	
                rt_thread_detach(thd_SPThread2);
                rt_thread_detach(thd_SPThread3);
                rt_thread_detach(thd_mutexRed);
                rt_thread_detach(thd_mutexGreen);
                rt_thread_detach(thd_mutexBlue);


                rt_thread_startup(thd_messagerecv);//������Ϣ�����߳�
                //ȡ���յ���������Ϊһ����Ϣ
			    for(int i=0;i<8;i++)
				recvData[i] = gcRecvBuf[i+9];
		        //������Ϣ��ŵ���Ϣ����
			    rt_mq_send(mq,recvData,sizeof(recvData));
		    }

            

            if(gcRecvBuf[7]==SEM_CODE) //������Ϊ90�������ź������ܡ�
            {
                if(gcRecvBuf[8]==0x01)//�������Ϊ01�����������ù���
                {
                    printf("���յ��ź������ܿ�������ź�������ģ�鿪��\n");
                    rt_thread_detach(thd_bluelight);
                    rt_thread_detach(thd_greenlight);
                    rt_thread_detach(thd_messagerecv);
                    rt_thread_detach(thd_mutexRed);
                    rt_thread_detach(thd_mutexGreen);
                    rt_thread_detach(thd_mutexBlue);



	                rt_thread_startup(thd_SPThread1);//�����ź����߳�1
	                rt_thread_startup(thd_SPThread2);//�����ź����߳�2
	                rt_thread_startup(thd_SPThread3);//�����ź����߳�


                }
                if(gcRecvBuf[8]==0x00)//�������Ϊ00������رոù���
                {
                    printf("���յ��ź������ܽ�������ź�������ģ�����");
                    rt_thread_detach(thd_SPThread1);	
                    rt_thread_detach(thd_SPThread2);
                    rt_thread_detach(thd_SPThread3);
                    gpio_init(LIGHT_BLUE,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_GREEN,GPIO_OUTPUT,LIGHT_OFF);
                    gpio_init(LIGHT_RED,GPIO_OUTPUT,LIGHT_OFF);

                }

            }

            if(gcRecvBuf[7]==MUTEX_CODE) //������Ϊ90���������������ܡ�
            {
                if(gcRecvBuf[8]==0x01)
                {
                    printf("���յ����������ܿ����������������ģ�鿪��\n");
                    rt_thread_detach(thd_bluelight);
                    rt_thread_detach(thd_greenlight);
                    rt_thread_detach(thd_messagerecv);
                    rt_thread_detach(thd_SPThread1);	
                    rt_thread_detach(thd_SPThread2);
                    rt_thread_detach(thd_SPThread3);

                    rt_thread_startup(thd_mutexRed);//��������߳�
	                rt_thread_startup(thd_mutexGreen);//�����̵��߳�
	                rt_thread_startup(thd_mutexBlue);//���������߳�
                }
                if(gcRecvBuf[8]==0x00)
                {
                    printf("���յ����������ܹر��������������ģ��ر�\n");
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
