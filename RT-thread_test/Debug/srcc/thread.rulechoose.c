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
    while(1)
    {
        rt_event_recv(EventWord,RULE_CHOOSE_EVENT,RT_EVENT_FLAG_OR|RT_EVENT_FLAG_CLEAR,RT_WAITING_FOREVER,&recvedstate);
        if(recvedstate==RULE_CHOOSE_EVENT)  //��������������ȷ
    	{
    		if(gcRecvBuf[3]==0x90) //������Ϊ90�������¼����ܡ�
            {
                rt_event_send(EventWord,BLUE_LIGHT_EVENT);

            }

            if(gcRecvBuf[3]==0x91) //������Ϊ91��������Ϣ���й��ܡ�
            {

            }

            if(gcRecvBuf[3]==0x92) //������Ϊ90�������ź������ܡ�
            {

            }

            if(gcRecvBuf[3]==0x93) //������Ϊ90���������������ܡ�
            {

            }

    	}
    }
}