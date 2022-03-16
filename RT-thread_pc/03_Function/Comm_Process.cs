using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RT_thread_pc._04_Base;
using System.Threading;
using System.Windows.Forms;
using RT_thread_pc._02_Form;


namespace RT_thread_pc._03_Function
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
        /// ----------------------------------------------------------------
        /// <summary>                                                       
        /// 功    能:向MCU端发送自定义字符串
        /// 内部调用:无                                                     
        /// </summary>                                                      
        /// <param name="SendArray">存放要发送的数据,字节数组</param>                     
        /// ----------------------------------------------------------------





        public void DataReceiveON(ref byte[] SendArray)
        {
            sci = new SCI(PublicVar.g_SCIComNum, PublicVar.g_SCIBaudRate);
            if (sci.SCIOpen())
            {
                sci.SCISendData(ref SendArray);
                
                sci.Close();
            }
        }

        

        public void DataReceiveOFF(ref byte[] SendArray)
        {
            sci = new SCI(PublicVar.g_SCIComNum, PublicVar.g_SCIBaudRate);
            {
                sci.SCIOpen();
                sci.SCISendData(ref SendArray);
                
                sci.SCIClose();
            }

        }


        ///-----------------------------------------------------------------
        /// <summary>                                                       
        /// 对    象:SCIPort                                                
        /// 事    件:DataReceived                                           
        /// 功    能:串口接收数据                                           
        /// 函数调用:(1)SCIReceiveData,串口接收函数                         
        ///          (2)SCIUpdateRevtxtbox,更新文本框中的内容               
        /// </summary>                                                      
        /// <param name="sender"></param>                                   
        /// <param name="e"></param>                                        
        ///-----------------------------------------------------------------
       


    }

        
    }

