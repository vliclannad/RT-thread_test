---������˵����---
��1������ժҪ������BIOS��STM32L431����
��2������оƬ�������̻���BIOS����,����0����
��3�����������AHL-GEC-IDE������STM32cubeIDE
��4��Ӳ��������AHL-STM32L431��ʵ����ֻҪ��STM32L431���ɣ�
              ��AHL-GEC��չ�壬����ɫ��ָʾ
��5��Ӳ�����ӣ���"..\05_UserBoard\user"�ļ�
��6�����ܼ�����
              �� ʵ������ÿ10����˸һ��,�������¼���
              �� �̵��̵߳ȴ����¼��֣�ת���̵�״̬
 ע�⣺�鿴���Խ����Ҫ����User���ڣ��򿪡����ߡ�->�����ڹ��ߡ����򿪴���


��20200915��Ҷ������
��������δפ����User�������
1.���������޸�
��1��STM32L431RCTX_FLASH.ld�ļ�
����USER����ʼ������Ϊ��GEC_USER_SECTOR_START =31;��
��2��startup_stm32l431rctx.s�ļ�
������䡰bl entry��Ϊ��bl main��
��2��gec.h�ļ�
���޸�
����USER����ʼ������Ϊ��#define GEC_USER_SECTOR_START    (31)��
���ĺ����б�ʼ������Ϊ��#define GEC_COMPONENT_LST_START  (24)��
���Ķ�̬���ʼ������Ϊ��#define GEC_DYNAMIC_START        (22)��
���Ķ�̬�������������Ϊ��#define GEC_DYNAMIC_END	      (23)��
������
�ڡ�GEC������Ϣ���·�������䣺
#define BIOS_SVC_IRQn            (11)
#define BIOS_PendSV_Handler      (14)
#define BIOS_SysTick_Handler     (15)
���ļ����·�����RT-Thread���ӳ�亯��ӳ���ַ������
//���䶯��RT-Thread��غ�������===================================================
#define OS_start  ((void (*)(void (*func)(void)))(component_fun[34]))
#define thread_create  ((uint8_t (*)(const char *name,void (*entry)(void *parameter),void *parameter,uint32_t stack_size,uint8_t priority,uint32_t tick))(component_fun[35]))
#define thread_start  ((void (*)(uint8_t threadIndex))(component_fun[36]))
#define thread_wait  ((void (*)(uint32_t millisec))(component_fun[37]))
#define heap_init  ((void (*)(uint32_t userHeapBase))(component_fun[33]))
��3��gec.c�ļ�
�ڡ�//��USER�ж��������BIOS����д�봮�ڵ��жϴ�������ַ���·�������䣺
user[BIOS_SVC_IRQn]=(uint32_t)bios[BIOS_SVC_IRQn];
user[BIOS_PendSV_Handler]=(uint32_t)bios[BIOS_PendSV_Handler];
user[BIOS_SysTick_Handler]=(uint32_t)bios[BIOS_SysTick_Handler];
��4��includes.h�ļ�
����䡰//���ڴ�����ȫ�ֱ��������·����ӱ���
G_VAR_PREFIX uint8_t gthd_redlight;
G_VAR_PREFIX uint8_t gthd_greenlight;
G_VAR_PREFIX uint8_t gthd_bluelight;
��5��main.c�ļ�
��ȫ�޸ģ��������ݰ���RT-Thread����������̵������̴߳���������
��6��ɾ��08_RT-Thread�ļ��м����ڲ������������ļ�
��7��ɾ��09_RT-ThreadPrg�ļ��м����ڲ������������ļ�

==================================================================================
�������ƣ�User_RT-Thread_Resident_STM32
��Ȩ���У�SUDA-ARM(sumcu.suda.edu.cn)
�汾���£�2020-09-15
������ܣ�������Ϊ����STM32L431RC΢��������RT-Threadפ����User�˳���
������ʵ���ˣ���1����User�˵���BIOS�����е�RT-Thread��غ�����ʵ��RT-Thread���������̴߳���
			 ��2�������˺�ơ��̵ƺ����������û��̡߳�
             ��2��ʵ�ֺ��ÿ5����˸һ�Σ��̵�ÿ10����˸һ�Σ�����ÿ20����˸һ�Ρ�
==================================================================================
2. �������
(1)AHL-GEC-IDE 4.11
3. Ӳ������
���İ壺���«ϵ��STM32L432RC���İ�  
UART2���ߣ� microUSB������

---���ΰ�User�����Ϊֱ�Ӵ�����������ֻ����������---
   ��1��03_MCU�ļ����е�.ld�У�
        GEC_USER_SECTOR_START  =0;    /*USER����ʼ������*/
   ��2��04_GEC�ļ�����gec.h�ļ�
         #define GEC_USER_SECTOR_START    (0)  
    �����ĳ���ɾ��Debug,���±����ʹ��SWDд�������أ�ֱ�����У�����ҪBIOS
         


---��ֲ����---��20200806��
��ͬоƬBIOS��User��ܻ�������
02_CPU ���ļ��г�cpu.h֮�⣬�����ļ�BIOS������User����ͬ
       cpu.h �䶯��1������2��������MCU�ͺű䶯
03_MCU mcu.h �䶯��1������3��,����MCU�ͺű䶯����BIOS������User����ͬ
             �ڸ��ļ����޸�MCU�ͺż�BIOS�汾��
       .ld�ļ�������MCU�ͺű䶯,��BIOS������User���̲�ͬ
       .s�ļ����Ķ�����BSS������BIOS������User���̲�ͬ
04_GEC ��оƬBIOS����һ�£�
       ��оƬUser����һ�£���ͬоƬBIOS��User���̵�04_GEC
       ���ݲ�ͬ
05_UserBoard BIOS�г�ȥUser.h����MCU�ͺű䶯�������ļ���ͬ
06��07�ļ��У���оƬBIOS��ͬ��ͬ���ܵ�User��ͬ


---�汾��ʷ---

��20200830�� V3.5  �淶���򣬹淶����Userģ�壬��ӦRTOS
��20200829�� V3.4  ��λ�����ö�̬����
��20200812���޸�.s�ļ���ȱʡ�жϣ�ֱ�ӷ���
��20200630����1����ȡ��ӦоƬ�Ĺٷ�����������
            ��2�����ձ�BIOS��׼���̣��������ļ��нṹ��
                 01_Doc�����makefile�ļ�������˵���ĵ�
                 02_CPU������ں�ͷ�ļ���
                         ���Ʊ������е�cpu.h�����ݿ���ֲ�Ա�ʶ
                         �ԡ��䶯�����ּ��ԸĶ���ʹ֮��ӦĿ��оƬ��
                 03_MCU����������ļ��������ļ��ͻ���������gpio��uart��flash����
                         ���Ʊ������е�mcu.h�����ݿ���ֲ�Ա�ʶ�ԡ��䶯�����ּ��ԸĶ���
                         ʹ֮��ӦĿ��оƬ��
                         �����ļ����޸ģ����Ʊ����������ļ��ĵڣ�1�����ֲ����ԸĶ���
                         ʹ֮��ӦĿ��оƬ��Flash�ֶ��и��ֶεĸ�ֵ��ʽֱ�ӿ�������
                         �������ļ��ĵڣ�2�����֡�Section�ֶν������̵ĵڣ�3������
                         ��ͷ���ġ��̶������ָ��Ʋ������ͷ����
                         ���ձ�׼���������ļ����洢�ռ��Ϊ��Ӧ�ķֶΡ�
                         ����BIOS�ֶεĴ�С�ڱ������ݳ����С��ȡ��С��ֵ��
                         ��̬����ֶΡ����������б�ֶξ�ȡ4KB��С���ң��Ӵ洢�ռ��С��
                         ������������ֶο�ȡ10KB�����ϡ�
                         �ڶ�Ӧ��SECTIONS����ͬ���Ը����ֶθ�����Ӧ�Ķ��塣
                 04_GEC��05_UserBoard��06_SoftComponent��07_NosPrgֱ�ӿ�����
                         ��gec.h��user.h�С��䶯�����ּ��ԸĶ���ʹ֮��ӦĿ��оƬ
��20200526��V3.0 ��1��MCU_TYPE��Ϊ3.0����2��ɾ��mcu.h�����ö��壻
                 ��3���޸�����ת�����������ڲ�������