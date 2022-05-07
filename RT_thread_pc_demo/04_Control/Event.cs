using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RT_thread_pc_demo;
using System.Threading;

namespace RT_thread_pc_demo._04_Control
{
    public partial class Event : UserControl
    {
        SCI sci;
        string str=String.Empty;

        delegate void handleinterfaceupdatedelegate(Object textbox,
                                                    string text);
        public Event()
        {
            InitializeComponent();
        }



        private void BtnSwitch_event_Click(object sender, EventArgs e)
        {

            Comm_Process comm = new Comm_Process();
            Button button = (Button)sender;
            PublicVar.g_TextBox = this.textBox_event;
            if (PublicVar.g_SCIComNum == null)
            {
                DialogResult dr = MessageBox.Show("    设备未连接！", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (button.Text == "开始实验")
                {
                    string a = "开始实验";
                    send_command(ref PublicVar.event_enable, ref a);

                    button.Text = "结束实验";//修改按钮上文字
                    Main.Menu_change += mcu_result;

                }
                else if (button.Text == "结束实验")
                {
                    string b = "结束实验";
                    send_command(ref PublicVar.event_close, ref b);

                    button.Text = "开始实验";
                }

            }


        }

        ///-----------------------------------------------------------------
        /// <summary>                                                       
        /// 函数名:send_command                                     
        /// 参  数:(1)byte[],要发送的命令             
        ///        (2)string类型,要放入按钮text                    
        /// 功  能:依据按钮text，发送命令，增加或删除串口接收委托       
        /// 返  回:无                                                       
        /// </summary>                                                      
        /// <param name="textbox"></param>                                  
        /// <param name="str"></param>                                      
        ///-----------------------------------------------------------------
        public void send_command(ref byte[] SendArray, ref string a)
        {

            if (a == "演示开始")
            {
                sci = new SCI(PublicVar.g_SCIComNum, PublicVar.g_SCIBaudRate);
                if (sci.SCIOpen())
                {
                    //sci.SCIOpen();
                    sci.SCISendData(ref SendArray);
                    sci.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SCIPort_DataReceived);//订阅事件
                    sci.SCIReceInt(1);
                }

            }
            else if (a == "演示结束")
            {
                sci.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.SCIPort_DataReceived);
                if (sci.IsOpen)
                {
                    sci.SCISendData(ref SendArray);
                    sci.SCIClose();
                }
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
    private void SCIPort_DataReceived(object sender,
          System.IO.Ports.SerialDataReceivedEventArgs e)
    {
            //String str = String.Empty;
            bool Flag;//标记串口接收数据是否成功
            int len;//标记接收的数据的长度

            byte[] ch2 = new byte[2];



            
            
            Flag = sci.SCIReceiveData(ref PublicVar.g_ReceiveByteArray);
            if (Flag == true)//串口接收数据成功
                {
                    len = PublicVar.g_ReceiveByteArray.Length;
                    //对于字符串形式,考虑到可能有汉字,
                    //直接调用系统定义的函数,处理整个字符串
                    str = Encoding.GetEncoding("GB2312").GetString(PublicVar.g_ReceiveByteArray);

                SCIUpdateRevtxtbox(PublicVar.g_TextBox, str);
               

            }
    }

        ///-----------------------------------------------------------------
        /// <summary>                                                       
        /// 函数名:SCIUpdateRevtxtbox                                       
        /// 参  数:(1)textbox,Object类型,接收数据要放入的文本框             
        ///        (2)text,string类型,要放入文本框的数据                    
        /// 功  能:若串行接收与Object不在同一线程中运行，那么通过invoke     
        ///        跨线程用串口接收到的数据来更新接收文本框中的数据         
        /// 返  回:无                                                       
        /// </summary>                                                      
        /// <param name="textbox"></param>                                  
        /// <param name="str"></param>                                      
        ///-----------------------------------------------------------------
        private void SCIUpdateRevtxtbox(Object textbox, string text)
        {

            if (((TextBox)textbox).InvokeRequired)
            {
                handleinterfaceupdatedelegate InterFaceUpdate = new
                   handleinterfaceupdatedelegate(SCIUpdateRevtxtbox);
                this.Invoke(InterFaceUpdate, new object[] { textbox, text });
            }
            else
            {
                ((TextBox)textbox).Text += text;
                //把光标放在最后一行
                ((TextBox)textbox).SelectionStart =
                                           ((TextBox)textbox).Text.Length;
                //将文本框中的内容调整到当前插入符号位置
                ((TextBox)textbox).ScrollToCaret();
            }
        }

        private void mcu_result(object sender,EventArgs e)
        {
            sci.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.SCIPort_DataReceived);
            if (sci.IsOpen)
            {
                //sci.SCISendData(ref PublicVar.mcuresult);
                sci.SCIClose();
            }

        }

        
    }
}
