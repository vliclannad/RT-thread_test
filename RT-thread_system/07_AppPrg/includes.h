///=====================================================================
//�ļ����ƣ�includes.h�ļ�
//������λ��SD-Arm(sumcu.suda.edu.cn)
//���¼�¼��20181201-20200627
//��ֲ���򣺡��̶���
//=====================================================================

#ifndef  INCLUDES_H     //��ֹ�ظ����壨INCLUDES_H ��ͷ��
#define  INCLUDES_H

//----------------------------------------------------------------------
//��1�������õ��Ĺ���
#include "user.h"
#include <OsFunc.h>
#include "NumToStr.h"

//----------------------------------------------------------------------
//��2��ȫ��ʹ�õĺ곣����
#define RULE_CHOOSE_EVENT  (1<<1)      //��������ѡ���¼�λ��1λ
#define GREEN_LIGHT_EVENT  (1<<2)      //�����̵��¼�Ϊ�¼��ֵ�2λ
#define BLUE_LIGHT_EVENT  (1<<3)      //���������¼�Ϊ�¼��ֵ�3λ
//----------------------------------------------------------------------
//��3���Զ�����������

//----------------------------------------------------------------------

//��4������ȫ�ֱ����������淶��ע2��
//���������궨��ȫ�ֱ���ǰ׺G_VAR_PREFIX��ʵ��ԭ���ע3��
#ifdef GLOBLE_VAR              //GLOBLE_VAR��main.c�ļ����к궨��
  #define G_VAR_PREFIX         //ǰ׺G_VAR_PREFIX����Ϊ��
#else                          //GLOBLE_VAR�ڷ�main.c�ļ����޶���
  #define G_VAR_PREFIX extern  //ǰ׺G_VAR_PREFIX����Ϊ"extern"
#endif
//���ڴ�����ȫ�ֱ�����


//��ϵͳ������
G_VAR_PREFIX vuint16_t gcRecvLen;
G_VAR_PREFIX vuint16_t gcRecvDCLen;
G_VAR_PREFIX vuint8_t  gcRecvBuf[MCU_SECTORSIZE];
//���û����ӣ�
G_VAR_PREFIX rt_event_t EventWord;
G_VAR_PREFIX rt_mq_t mq;
G_VAR_PREFIX rt_sem_t SP;
G_VAR_PREFIX	rt_thread_t thd_rulechoose;
G_VAR_PREFIX	rt_thread_t thd_greenlight;
G_VAR_PREFIX 	rt_thread_t thd_bluelight;
G_VAR_PREFIX 	rt_thread_t thd_messagerecv;
G_VAR_PREFIX 	rt_thread_t thd_SPThread1;
G_VAR_PREFIX 	rt_thread_t thd_SPThread2;
G_VAR_PREFIX 	rt_thread_t thd_SPThread3;
//�̺߳�������
void app_init(void);
void thread_rulechoose();
void thread_greenlight();
void thread_bluelight();
void thread_messagerecv();
void thread_SPThread1();
void thread_SPThread2();
void thread_SPThread3();

void thread_cloose(uint16_t thread_number);
#define delay_ms(x)  rt_thread_delay(x)
//----------------------------------------------------------------------


#endif                  //��ֹ�ظ����壨INCLUDES_H ��β��


/*
 ֪ʶҪ�أ�
 ע1��ȫ��ʹ�õĺ곣����ʹ��ȫ��д
 ע2��ȫ�ֱ�������һ����g��ͷ�������ܱ�֤ȫ������Ψһ�ԣ�����һ��Ҫע��
      �京�壬������ʱ��׼��ֵ��
 ע3��ȫ�ֱ���һ�������ദʹ�ô������������Ϊ�˽��ȫ�ֱ����ظ�����
 �����⣬��GLOBLE_VAR����main.c������������ֻ����main.c�а���
 ��ͷ�ļ�ʱ�Ż�����ȫ�ֱ������������ļ��а������ļ�ʱ������ʱ���ͻ��Զ���
 ��ǰ׺extern��������main������������ȫ�ֱ��������ļ���ֱ��ʹ�á�
 */


