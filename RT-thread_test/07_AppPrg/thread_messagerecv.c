#include "includes.h"

//======================================================================
//�������ƣ�thread_messagerecv
//�������أ���
//����˵������
//���ܸ�Ҫ���������������Ϣ�����ӡ����ص���Ӧ����Ϣ������ʱ��Ϣ��������Ϣ�ĸ���
//�ڲ����ã���
//======================================================================
void thread_messagerecv()
{
	//��1��======�����ֲ�����==========================================
    uint8_t temp[8];
	char *cnt;
	uint8_t recvState;
	printf("��һ�ν�����Ϣ�����߳�!\r\n");
	 //��2��======��ѭ������ʼ��==========================================
    while (1)
    {
	    //�ȴ���Ϣ
		recvState=mq_recv(mq,&temp,sizeof(temp),RT_WAITING_FOREVER);

		if(recvState==0)  //�������Ϣ
       	{
			cnt = rt_malloc(1);  
    	   	rt_sprintf(cnt,"%d",mq->entry);
    	   	uart_send_string(UART_User,(void*)"��Ϣ��������Ϣ��=");
    	   	uart_send_string(UART_User,(uint8_t *)cnt);
    	   	uart_send_string(UART_User,(void *) "\r\n");
    	   	uart_send_string(UART_User,(void*) "��ǰȡ������Ϣ=");
    	   	uart_sendN(UART_User,8,temp);
    	   	uart_send_string(UART_User,(void *) "\r\n");
    	   	delay_ms(1000);                //�ӳ٣�Ϊ����ʾ��Ϣ�ѻ������
    	 }
    }//��2��======��ѭ����������==========================================
}