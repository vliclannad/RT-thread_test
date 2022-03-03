---【程序说明】---
（1）程序摘要：基于BIOS的STM32L431工程
（2）运行芯片：本工程基于BIOS运行,不从0启动
（3）软件环境：AHL-GEC-IDE，兼容STM32cubeIDE
（4）硬件环境：AHL-STM32L431，实质是只要是STM32L431即可，
              接AHL-GEC扩展板，有三色灯指示
（5）硬件连接：见"..\05_UserBoard\user"文件
（6）功能简述：
              ① 实现蓝灯每10秒闪烁一次,并设置事件字
              ② 绿灯线程等待到事件字，转换绿灯状态
 注意：查看测试结果需要连接User串口，打开“工具”->“串口工具”，打开串口


【20200915】叶柯阳改
本工程与未驻留的User工程相比
1.做了以下修改
（1）STM32L431RCTX_FLASH.ld文件
更改USER程序开始扇区号为“GEC_USER_SECTOR_START =31;”
（2）startup_stm32l431rctx.s文件
更改语句“bl entry”为“bl main”
（2）gec.h文件
①修改
更改USER程序开始扇区号为“#define GEC_USER_SECTOR_START    (31)”
更改函数列表开始扇区号为“#define GEC_COMPONENT_LST_START  (24)”
更改动态命令开始扇区号为“#define GEC_DYNAMIC_START        (22)”
更改动态命令结束扇区号为“#define GEC_DYNAMIC_END	      (23)”
②新增
在“GEC基本信息”下方新增语句：
#define BIOS_SVC_IRQn            (11)
#define BIOS_PendSV_Handler      (14)
#define BIOS_SysTick_Handler     (15)
在文件最下方新增RT-Thread相关映射函数映射地址声明：
//【变动】RT-Thread相关函数声明===================================================
#define OS_start  ((void (*)(void (*func)(void)))(component_fun[34]))
#define thread_create  ((uint8_t (*)(const char *name,void (*entry)(void *parameter),void *parameter,uint32_t stack_size,uint8_t priority,uint32_t tick))(component_fun[35]))
#define thread_start  ((void (*)(uint8_t threadIndex))(component_fun[36]))
#define thread_wait  ((void (*)(uint32_t millisec))(component_fun[37]))
#define heap_init  ((void (*)(uint32_t userHeapBase))(component_fun[33]))
（3）gec.c文件
在“//改USER中断向量表的BIOS程序写入串口的中断处理程序地址”下方新增语句：
user[BIOS_SVC_IRQn]=(uint32_t)bios[BIOS_SVC_IRQn];
user[BIOS_PendSV_Handler]=(uint32_t)bios[BIOS_PendSV_Handler];
user[BIOS_SysTick_Handler]=(uint32_t)bios[BIOS_SysTick_Handler];
（4）includes.h文件
在语句“//（在此增加全局变量）”下方增加变量
G_VAR_PREFIX uint8_t gthd_redlight;
G_VAR_PREFIX uint8_t gthd_greenlight;
G_VAR_PREFIX uint8_t gthd_bluelight;
（5）main.c文件
完全修改，具体内容包括RT-Thread启动，红灯绿灯蓝灯线程创建和运行
（6）删除08_RT-Thread文件夹及其内部包含的所有文件
（7）删除09_RT-ThreadPrg文件夹及其内部包含的所有文件

==================================================================================
工程名称：User_RT-Thread_Resident_STM32
版权所有：SUDA-ARM(sumcu.suda.edu.cn)
版本更新：2020-09-15
程序介绍：本程序为基于STM32L431RC微控制器的RT-Thread驻留的User端程序。
本程序实现了：（1）在User端调用BIOS程序中的RT-Thread相关函数，实现RT-Thread的启动和线程创建
			 （2）创建了红灯、绿灯和蓝灯三个用户线程。
             （2）实现红灯每5秒闪烁一次，绿灯每10秒闪烁一次，蓝灯每20秒闪烁一次。
==================================================================================
2. 软件环境
(1)AHL-GEC-IDE 4.11
3. 硬件环境
核心板：金葫芦系列STM32L432RC核心板  
UART2接线： microUSB串口线

---【何把User程序改为直接从零启动程序（只有两处）】---
   （1）03_MCU文件夹中的.ld中，
        GEC_USER_SECTOR_START  =0;    /*USER程序开始扇区号*/
   （2）04_GEC文件夹中gec.h文件
         #define GEC_USER_SECTOR_START    (0)  
    这样的程序，删除Debug,重新编译后，使用SWD写入器下载，直接运行，不需要BIOS
         


---移植规则---【20200806】
不同芯片BIOS及User框架基本规则
02_CPU 该文件夹除cpu.h之外，其他文件BIOS工程与User工程同
       cpu.h 变动（1）～（2），根据MCU型号变动
03_MCU mcu.h 变动（1）～（3）,根据MCU型号变动，且BIOS工程与User工程同
             在该文件中修改MCU型号及BIOS版本号
       .ld文件：根据MCU型号变动,且BIOS工程与User工程不同
       .s文件：改动类似BSS处，且BIOS工程与User工程不同
04_GEC 各芯片BIOS工程一致，
       各芯片User工程一致，但同芯片BIOS与User工程的04_GEC
       内容不同
05_UserBoard BIOS中除去User.h根据MCU型号变动，其他文件相同
06、07文件夹：各芯片BIOS相同，同功能的User相同


---版本历史---

【20200830】 V3.5  规范程序，规范对于User模板，适应RTOS
【20200829】 V3.4  复位后重置动态命令
【20200812】修改.s文件，缺省中断，直接返回
【20200630】（1）获取对应芯片的官方工程样例。
            （2）参照本BIOS标准工程，整理工程文件夹结构。
                 01_Doc：存放makefile文件和其他说明文档
                 02_CPU：存放内核头文件。
                         复制本工程中的cpu.h，根据可移植性标识
                         对【变动】部分加以改动，使之适应目标芯片。
                 03_MCU：存放链接文件、启动文件和基本驱动（gpio、uart、flash）。
                         复制本工程中的mcu.h，根据可移植性标识对【变动】部分加以改动，
                         使之适应目标芯片。
                         链接文件的修改：复制本工程链接文件的第（1）部分并加以改动，
                         使之适应目标芯片。Flash字段中各分段的赋值方式直接拷贝本工
                         程链接文件的第（2）部分。Section字段将本工程的第（3）部分
                         中头部的【固定】部分复制并添加至头部。
                         参照标准工程链接文件将存储空间分为对应的分段。
                         其中BIOS分段的大小在编译后根据程序大小，取最小的值。
                         动态命令分段、构建函数列表分段均取4KB大小左右，视存储空间大小，
                         构建函数代码分段可取10KB及以上。
                         在对应的SECTIONS断中同样对各个分段给出对应的定义。
                 04_GEC、05_UserBoard、06_SoftComponent、07_NosPrg直接拷贝。
                         对gec.h和user.h中【变动】部分加以改动，使之适应目标芯片
【20200526】V3.0 （1）MCU_TYPE改为3.0；（2）删除mcu.h中无用定义；
                 （3）修改类型转换构件名及内部函数名