///=====================================================================
//文件名称：includes.h文件
//制作单位：SD-Arm(sumcu.suda.edu.cn)
//更新记录：20181201-20200627
//移植规则：【固定】
//=====================================================================

#ifndef  INCLUDES_H     //防止重复定义（INCLUDES_H 开头）
#define  INCLUDES_H

//----------------------------------------------------------------------
//（1）包含用到的构件
#include "user.h"
#include <OsFunc.h>
#include "NumToStr.h"

//----------------------------------------------------------------------
//（2）全局使用的宏常数。
#define RULE_CHOOSE_EVENT  (1<<1)      //定义命令选择事件位第1位
#define GREEN_LIGHT_EVENT  (1<<2)      //定义绿灯事件为事件字第2位
#define BLUE_LIGHT_EVENT  (1<<3)      //定义蓝灯事件为事件字第3位
//----------------------------------------------------------------------
//（3）自定义数据类型

//----------------------------------------------------------------------

//（4）声明全局变量。命名规范见注2。
//【不动】宏定义全局变量前缀G_VAR_PREFIX。实现原理见注3。
#ifdef GLOBLE_VAR              //GLOBLE_VAR在main.c文件中有宏定义
  #define G_VAR_PREFIX         //前缀G_VAR_PREFIX定义为空
#else                          //GLOBLE_VAR在非main.c文件中无定义
  #define G_VAR_PREFIX extern  //前缀G_VAR_PREFIX定义为"extern"
#endif
//（在此增加全局变量）


//（系统保留）
G_VAR_PREFIX vuint16_t gcRecvLen;
G_VAR_PREFIX vuint16_t gcRecvDCLen;
G_VAR_PREFIX vuint8_t  gcRecvBuf[MCU_SECTORSIZE];
//（用户增加）
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
//线程函数声明
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


#endif                  //防止重复定义（INCLUDES_H 结尾）


/*
 知识要素：
 注1：全局使用的宏常数，使用全大写
 注2：全局变量命名一律以g开头，尽可能保证全工程内唯一性，并且一定要注明
      其含义，（声明时不准赋值）
 注3：全局变量一处声明多处使用处理方法代码段是为了解决全局变量重复声明
 的问题，宏GLOBLE_VAR仅在main.c中声明，所以只有在main.c中包含
 本头文件时才会声明全局变量，在其他文件中包含本文件时，编译时，就会自动加
 上前缀extern，表明是main函数中声明的全局变量，该文件中直接使用。
 */


