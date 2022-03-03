//======================================================================
//�ļ����ƣ�Os_Self_API.h��RTOS��������ӿ�ͷ�ļ���
//������λ��SD-EAI&IoT Lab.(sumcu.suda.edu.cn)
//���¼�¼��20210326
//�ļ����ݣ���1��BIOS��פ����RTOS������ӳ��궨�壨��ͨ���������������
//              ʹ��BIOS�е�RTOS�ں˺�����
//          ��2��RTOS�Ľṹ������
//���磺���������rt_event_create�ĺ궨�壬����ͨ��������BIOS�иú���
//======================================================================
#ifndef Os_Self_API_H   //��ֹ�ظ�����
#define Os_Self_API_H

#define RTThread_Start   0      //1=RTOS�ں�Դ����User�����У�0=RTOS�ں�Դ��פ����BIOS��

//��1��RT-Thread��غ곣������
//�¼�
#define RT_EVENT_FLAG_AND               0x01            /**< logic and */
#define RT_EVENT_FLAG_OR                0x02              /**< logic or */
#define RT_EVENT_FLAG_CLEAR             0x04            /**< clear flag */
//IPC��ر�־
#define RT_IPC_FLAG_FIFO                0x00            /**< FIFOed IPC. @ref IPC. */
#define RT_IPC_FLAG_PRIO                0x01            /**< PRIOed IPC. @ref IPC. */

#define RT_IPC_CMD_UNKNOWN              0x00            /**< unknown IPC command */
#define RT_IPC_CMD_RESET                0x01            /**< reset IPC object */

#define RT_WAITING_FOREVER              -1              /**< Block forever until get resource. */
#define RT_WAITING_NO                   0               /**< Non-block. */

#define RT_EOK                          0               /**< There is no error */

//��2��RT-Thread��غ�������===================================================
#define OS_start  ((void (*)(void (*func)(void)))(component_fun[34]))
#define rt_thread_create  ((rt_thread_t (*)(const char *name,void (*entry)(void *parameter),\
                                          void *parameter,rt_uint32_t stack_size,rt_uint8_t priority,\
                                                 rt_uint32_t tick))(component_fun[35]))
#define rt_thread_startup  ((rt_err_t (*)(rt_thread_t thread))(component_fun[36]))
#define rt_thread_delay  ((rt_err_t (*)(rt_tick_t millisec))(component_fun[37]))
//#define heap_init  ((void (*)(uint32_t userHeapBase))(component_fun[33]))
#define rt_thread_self  ((rt_thread_t (*)(void))(component_fun[38]))
//�¼�
#define rt_event_create  ((rt_event_t (*)(const char *name, rt_uint8_t flag))(component_fun[41]))
#define rt_event_recv  ((rt_err_t (*)(rt_event_t event, rt_uint32_t set, rt_uint8_t option,\
                                     rt_int32_t timeout,rt_uint32_t *recved))(component_fun[42]))
#define rt_event_send  ((rt_err_t (*)(rt_event_t event,rt_uint32_t set))(component_fun[43]))
//�ź���
#define rt_sem_create  ((rt_sem_t (*)(const char *name, rt_uint32_t value, rt_uint8_t flag))(component_fun[46]))
#define rt_sem_take  ((rt_err_t (*)(rt_sem_t sem, rt_int32_t time))(component_fun[47]))
#define rt_sem_release  ((rt_err_t (*)(rt_sem_t sem))(component_fun[48]))
//#define sem_getNum  ((uint8_t (*)(uint8_t SpIndex))(component_fun[49]))
//������
#define rt_mutex_create  ((rt_mutex_t (*)(const char *name,rt_uint8_t flag))(component_fun[52]))
#define rt_mutex_take  ((rt_err_t (*)(rt_mutex_t mutex, rt_int32_t time))(component_fun[53]))
#define rt_mutex_release  ((rt_err_t (*)(rt_mutex_t mutex))(component_fun[54]))
//��Ϣ����
#define rt_mq_create  ((rt_mq_t (*)(const char *name,rt_size_t msg_size,\
                                            rt_size_t max_msgs,rt_uint8_t flag))(component_fun[57]))
#define rt_mq_send  ((rt_err_t (*)(rt_mq_t mq, void *buffer, rt_size_t size))(component_fun[58]))
#define rt_mq_recv  ((rt_err_t (*)(rt_mq_t mq, void *buffer,\
                                            rt_size_t size,rt_int32_t timeout))(component_fun[59]))
#define rt_malloc  ((void* (*)(rt_size_t size))(component_fun[60]))
#define rt_sprintf  ((rt_int32_t (*)(char *buf, const char *format, ...))(component_fun[61]))
//#define mq_getIndex  ((uint8_t (*)(uint8_t MqIndex))(component_fun[62]))
//ϵͳʱ�亯��
#define rt_tick_get ((rt_tick_t (*)(void))(component_fun[63]))




//��3��rt-threadԴ�ļ����
#define RT_TIMER_SKIP_LIST_LEVEL          1
#define RT_NAME_MAX    8


enum rt_object_class_type
{
    RT_Object_Class_Null   = 0,                         /**< The object is not used. */
    RT_Object_Class_Thread,                             /**< The object is a thread. */
    RT_Object_Class_Semaphore,                          /**< The object is a semaphore. */
    RT_Object_Class_Mutex,                              /**< The object is a mutex. */
    RT_Object_Class_Event,                              /**< The object is a event. */
    RT_Object_Class_MailBox,                            /**< The object is a mail box. */
    RT_Object_Class_MessageQueue,                       /**< The object is a message queue. */
    RT_Object_Class_MemHeap,                            /**< The object is a memory heap */
    RT_Object_Class_MemPool,                            /**< The object is a memory pool. */
    RT_Object_Class_Device,                             /**< The object is a device */
    RT_Object_Class_Timer,                              /**< The object is a timer. */
    RT_Object_Class_Module,                             /**< The object is a module. */
    RT_Object_Class_Unknown,                            /**< The object is unknown. */
    RT_Object_Class_Static = 0x80                       /**< The object is a static object. */
};
/* RT-Thread basic data type definitions */

typedef signed   char                   rt_int8_t;      /**<  8bit integer type */
typedef signed   short                  rt_int16_t;     /**< 16bit integer type */
typedef signed   long                   rt_int32_t;     /**< 32bit integer type */
typedef signed long long                rt_int64_t;     /**< 64bit integer type */
typedef unsigned char                   rt_uint8_t;     /**<  8bit unsigned integer type */
typedef unsigned short                  rt_uint16_t;    /**< 16bit unsigned integer type */
typedef unsigned long                   rt_uint32_t;    /**< 32bit unsigned integer type */
typedef unsigned long long              rt_uint64_t;    /**< 64bit unsigned integer type */

typedef int                             rt_bool_t;      /**< boolean type */

/* 32bit CPU */
typedef long                            rt_base_t;      /**< Nbit CPU related date type */
typedef unsigned long                   rt_ubase_t;     /**< Nbit unsigned CPU related data type */

typedef rt_base_t                       rt_err_t;       /**< Type for error number */
typedef rt_uint32_t                     rt_time_t;      /**< Type for time stamp */
typedef rt_uint32_t                     rt_tick_t;      /**< Type for tick count */
typedef rt_base_t                       rt_flag_t;      /**< Type for flags */
typedef rt_ubase_t                      rt_size_t;      /**< Type for size number */
typedef rt_ubase_t                      rt_dev_t;       /**< Type for device */
typedef rt_base_t                       rt_off_t;       /**< Type for offset */

/* boolean type definitions */
#define RT_TRUE                         1               /**< boolean true  */
#define RT_FALSE                        0               /**< boolean fails */

/**@}*/

/* maximum value of base type */
#define RT_UINT8_MAX                    0xff            /**< Maxium number of UINT8 */
#define RT_UINT16_MAX                   0xffff          /**< Maxium number of UINT16 */
#define RT_UINT32_MAX                   0xffffffff      /**< Maxium number of UINT32 */
#define RT_TICK_MAX                     RT_UINT32_MAX   /**< Maxium number of tick */

#define RT_NULL                         (0)

struct rt_list_node
{
    struct rt_list_node *next;                          /**< point to next node. */
    struct rt_list_node *prev;                          /**< point to prev node. */
};
typedef struct rt_list_node rt_list_t;                  /**< Type for lists. */

/**
 * Single List structure
 */
struct rt_slist_node
{
    struct rt_slist_node *next;                         /**< point to next node. */
};
typedef struct rt_slist_node rt_slist_t;                /**< Type for single list. */


#define RT_OBJECT_FLAG_MODULE           0x80            /**< is module object. */

struct rt_object
{
    char       name[RT_NAME_MAX];                       /**< name of kernel object */
    rt_uint8_t type;                                    /**< type of kernel object */
    rt_uint8_t flag;                                    /**< flag of kernel object */

#ifdef RT_USING_MODULE
    void      *module_id;                               /**< id of application module */
#endif
    rt_list_t  list;                                    /**< list node of kernel object */
};
typedef struct rt_object *rt_object_t;                  /**< Type for kernel objects. */



struct rt_object_information
{
    enum rt_object_class_type type;                     /**< object class type */
    rt_list_t                 object_list;              /**< object list */
    rt_size_t                 object_size;              /**< object size */
};

struct rt_timer
{
    struct rt_object parent;                            /**< inherit from rt_object */

    rt_list_t        row[RT_TIMER_SKIP_LIST_LEVEL];

    void (*timeout_func)(void *parameter);              /**< timeout function */
    void            *parameter;                         /**< timeout function's parameter */

    rt_tick_t        init_tick;                         /**< timer timeout tick */
    rt_tick_t        timeout_tick;                      /**< timeout tick */
};
typedef struct rt_timer *rt_timer_t;

struct rt_thread
{
    /* rt object */
    char        name[RT_NAME_MAX];                      /**< the name of thread */
    rt_uint8_t  type;                                   /**< type of object */
    rt_uint8_t  flags;                                  /**< thread's flags */

#ifdef RT_USING_MODULE
    void       *module_id;                              /**< id of application module */
#endif

    rt_list_t   list;                                   /**< the object list */
    rt_list_t   tlist;                                  /**< the thread list */

    /* stack point and entry */
    void       *sp;                                     /**< stack point */
    void       *entry;                                  /**< entry */
    void       *parameter;                              /**< parameter */
    void       *stack_addr;                             /**< stack address */
    rt_uint32_t stack_size;                             /**< stack size */

    /* error code */
    rt_err_t    error;                                  /**< error code */

    rt_uint8_t  stat;                                   /**< thread status */

    /* priority */
    rt_uint8_t  current_priority;                       /**< current priority */
    rt_uint8_t  init_priority;                          /**< initialized priority */
#if RT_THREAD_PRIORITY_MAX > 32
    rt_uint8_t  number;
    rt_uint8_t  high_mask;
#endif
    rt_uint32_t number_mask;


    /* thread event */
    rt_uint32_t event_set;
    rt_uint8_t  event_info;


#if defined(RT_USING_SIGNALS)
    rt_sigset_t     sig_pending;                        /**< the pending signals */
    rt_sigset_t     sig_mask;                           /**< the mask bits of signal */

    void            *sig_ret;                           /**< the return stack pointer from signal */
    rt_sighandler_t *sig_vectors;                       /**< vectors of signal handler */
    void            *si_list;                           /**< the signal infor list */
#endif

    rt_ubase_t  init_tick;                              /**< thread's initialized tick */
    rt_ubase_t  remaining_tick;                         /**< remaining tick */

    struct rt_timer thread_timer;                       /**< built-in thread timer */

    void (*cleanup)(struct rt_thread *tid);             /**< cleanup function when thread exit */

    /* light weight process if present */
#ifdef RT_USING_LWP
    void        *lwp;
#endif

    rt_uint32_t user_data;                             /**< private user data beyond this thread */
};
typedef struct rt_thread *rt_thread_t;

struct rt_ipc_object
{
    struct rt_object parent;                            /**< inherit from rt_object */

    rt_list_t        suspend_thread;                    /**< threads pended on this resource */
};


/**
 * Semaphore structure
 */
struct rt_semaphore
{
    struct rt_ipc_object parent;                        /**< inherit from ipc_object */

    rt_uint16_t          value;                         /**< value of semaphore. */
    rt_uint16_t          reserved;                      /**< reserved field */
};
typedef struct rt_semaphore *rt_sem_t;



/**
 * Mutual exclusion (mutex) structure
 */
struct rt_mutex
{
    struct rt_ipc_object parent;                        /**< inherit from ipc_object */

    rt_uint16_t          value;                         /**< value of mutex */

    rt_uint8_t           original_priority;             /**< priority of last thread hold the mutex */
    rt_uint8_t           hold;                          /**< numbers of thread hold the mutex */

    struct rt_thread    *owner;                         /**< current owner of mutex */
};
typedef struct rt_mutex *rt_mutex_t;




struct rt_event
{
    struct rt_ipc_object parent;                        /**< inherit from ipc_object */

    rt_uint32_t          set;                           /**< event set */
};
typedef struct rt_event *rt_event_t;



/**
 * mailbox structure
 */
struct rt_mailbox
{
    struct rt_ipc_object parent;                        /**< inherit from ipc_object */

    rt_uint32_t         *msg_pool;                      /**< start address of message buffer */

    rt_uint16_t          size;                          /**< size of message pool */

    rt_uint16_t          entry;                         /**< index of messages in msg_pool */
    rt_uint16_t          in_offset;                     /**< input offset of the message buffer */
    rt_uint16_t          out_offset;                    /**< output offset of the message buffer */

    rt_list_t            suspend_sender_thread;         /**< sender thread suspended on this mailbox */
};
typedef struct rt_mailbox *rt_mailbox_t;



/**
 * message queue structure
 */
struct rt_messagequeue
{
    struct rt_ipc_object parent;                        /**< inherit from ipc_object */

    void                *msg_pool;                      /**< start address of message queue */

    rt_uint16_t          msg_size;                      /**< message size of each message */
    rt_uint16_t          max_msgs;                      /**< max number of messages */

    rt_uint16_t          entry;                         /**< index of messages in the queue */

    void                *msg_queue_head;                /**< list head */
    void                *msg_queue_tail;                /**< list tail */
    void                *msg_queue_free;                /**< pointer indicated the free node of queue */
};
typedef struct rt_messagequeue *rt_mq_t;


#endif    
