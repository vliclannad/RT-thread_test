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
                    printf("���յ��¼����ܿ�������¼�����ģ�鿪��\n");
                    grt_flag=1;
                    rt_event_send(EventWord,BLUE_LIGHT_EVENT);
                }
                if(gcRecvBuf[8]==0x00)//�������Ϊ00������رոù��ܣ���������С���̣߳���С���߳�������������
                {
                    printf("���յ��¼����ܽ�������¼�����ģ�����");
                    grt_flag=0;

                }
                

            }

            if(gcRecvBuf[7]==MESSAGE_CODE) //������Ϊ91��������Ϣ���й��ܡ�
            {
                //ȡ���յ���������Ϊһ����Ϣ
			    for(int i=0;i<8;i++)
				recvData[i] = gcRecvBuf[i+9];
		        //������Ϣ��ŵ���Ϣ����
			    rt_mq_send(mq,recvData,sizeof(recvData));
		    }

            

            if(gcRecvBuf[7]==SEM_CODE) //������Ϊ90�������ź������ܡ�
            {

            }

            if(gcRecvBuf[7]==MUTEX_CODE) //������Ϊ90���������������ܡ�
            {

            }

    	}
    }
}
