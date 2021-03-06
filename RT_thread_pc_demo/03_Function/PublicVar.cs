namespace RT_thread_pc_demo
{
    /// --------------------------------------------------------------------
    /// <summary>                                                           
    /// 类功能:定义全局变量                                                 
    /// </summary>                                                          
    /// <remarks></remarks>                                                 
    /// ------------------- ------------------------------------------------
    public  class PublicVar
    {
        //定义串口的全局变量,设置成静态的
        public static byte[] g_ReceiveByteArray;//全局变量，存放接收的数据
        public static byte[] g_SendByteArray;   //全局变量，存放要发送的数据
        public static byte[] g_SendByteLast;    //全局变量，存放最后的数据
        public static string g_SCIComNum;       //全局变量，存放选择的串口号
        public static int g_SCIBaudRate=115200;        //全局变量，存放选择的波特率
        public static int g_Uflag;//全局变量，是否和MCU端连接成功的标志
        public static object g_TextBox;//全局变量，要更新的textbox
        public static int g_SCIflag;

        public static byte[] event_enable = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x90, 0x01};//事件功能开启命令
        public static byte[] event_close = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x90, 0x00};//事件功能关闭命令

        public static byte[] message_enable = { 0xA5, 0x5A, 0x0E, 0x83, 0x00, 0x03, 0x01, 0x91, 0x01, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37,
                                                 0xA5, 0x5A, 0x0E, 0x83, 0x00, 0x03, 0x01, 0x91, 0x01, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37,
                                                  0xA5, 0x5A, 0x0E, 0x83, 0x00, 0x03, 0x01, 0x91, 0x01, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37,
                                                0xA5, 0x5A, 0x0E, 0x83, 0x00, 0x03, 0x01, 0x91, 0x01, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37};//消息队列功能开启命令
        public static byte[] message_close = { 0x00 };
        public static byte[] sp_enable = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x92, 0x01 };//信号量功能开启命令
        public static byte[] sp_close = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x92, 0x00 };//信号量功能关闭命令
        public static byte[] mutex_enable = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x93, 0x01 };//互斥量功能开启命令
        public static byte[] mutex_close = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x93, 0x00 };//互斥量功能关闭命令
        public static byte[] delay_enable = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x94, 0x01 };//延时功能开启命令
        public static byte[] delay_close = { 0xA5, 0x5A, 0x06, 0x83, 0x00, 0x03, 0x01, 0x94, 0x00 };//延时功能关闭命令
        public static byte[] userShark = { 0xA5, 0x5A, 0x05, 0x83, 0x00, 0x03, 0x02, 0x66 };//mcu连接握手命令
        public static byte[] mcuresult = { 0xA5, 0x5A, 0x05, 0x83, 0x00, 0x03, 0x02, 0x77 };//mcu功能重置命令


        public static string path_main="..\\..\\05_Information\\main_information.txt";
        public static string path_delay_1 = "..\\..\\05_Information\\delay_information_1.txt";
        public static string path_delay_2 = "..\\..\\05_Information\\delay_information_2.txt";
        public static string path_event_1 = "..\\..\\05_Information\\event_information_1.txt";
        public static string path_event_2 = "..\\..\\05_Information\\event_information_2.txt";
        public static string path_message_1 = "..\\..\\05_Information\\message_information_1.txt";
        public static string path_message_2 = "..\\..\\05_Information\\message_information_2.txt";
        public static string path_sp_1 = "..\\..\\05_Information\\sp_information_1.txt";
        public static string path_sp_2 = "..\\..\\05_Information\\sp_information_2.txt";
        public static string path_mutex_1 = "..\\..\\05_Information\\mutex_information_1.txt";
        public static string path_mutex_2 = "..\\..\\05_Information\\mutex_information_2.txt";
    }
}