using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace RT_thread_pc_demo
{
    public  class Comm_Process
    {
        SCI sci;
        string[] SCIPorts;
        byte[] recvData = new byte[100];
        byte[] userShake = {0xA5,0x5A,0x01,0x66}; //与终端握手帧数据
        

        /// ----------------------------------------------------------------
        /// <summary>                                                       
        /// 功    能:构造当前类的对象,获取本机串口号数组
        /// 内部调用:无                                                     
        /// </summary>                                                      
        /// <param> 无 </param>                    
        /// ----------------------------------------------------------------
        public Comm_Process()
        {
            SCIPorts = SCI.SCIGetPorts();
        }


        /// ----------------------------------------------------------------
        /// <summary>                                                       
        /// 功    能:查找出与MCU端设备通信用的串口号，记录在全局变量g_SCIComNum中
        /// 内部调用:无                                                     
        /// </summary>                                                      
        /// <param> 无 </param>                    
        /// ----------------------------------------------------------------
        public void FindSCI()
        {
            for (int i = 0; i < SCIPorts.Length; i++)
            {
                sci = new SCI(SCIPorts[i], PublicVar.g_SCIBaudRate);
                if (sci.SCIOpen())
                {
                    sci.SCISendData(ref userShake);

                    Thread.Sleep(500);
                    if (sci.SCIReceiveData(ref recvData))
                    {

                        if (recvData.Length == 0 || !System.Text.Encoding.Default.GetString(recvData).Contains("I can see you"))
                        {
                            PublicVar.g_Uflag = 0;
                            sci.Close();
                            continue;
                        }
                        if (System.Text.Encoding.Default.GetString(recvData).Contains("I can see you"))   //记录UART_User串口的Com号
                        {
                            PublicVar.g_SCIComNum = SCIPorts[i];
                            PublicVar.g_Uflag = 1;
                            sci.Close();
                            break;                                                              //找到UART_User串口后，跳出循环
                        }
                    }
                }
            }
        }
    }

        
    }

