using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RT_thread_pc._03_Function;
using RT_thread_pc._04_Base;

namespace RT_thread_pc._02_Form
{
    public partial class Main : Form
    {
        Comm_Process Comm;
        SCI sci;

        delegate void handleinterfaceupdatedelegate(Object textbox,
                                                    string text);
        public Main()
        {


            InitializeComponent();
        }

        private void mcu_connect_Click(object sender, EventArgs e)
        {
            Comm = new Comm_Process();
            Comm.FindSCI();
            if(PublicVar.g_Uflag==1)
            {
                label_connectstate.Text = "设备已连接";
            }
            if(PublicVar.g_Uflag==0)
            {
                label_connectstate.Text = "设备未连接";
            }


        }

        private void BtnSwitch_event_Click(object sender, EventArgs e)

        {
            Comm=new Comm_Process();
            PublicVar.g_TextBox = this.textBox_event;
            if(this.BtnSwitch_event.Text=="开启功能")
            {
                Comm.DataReceiveON(ref PublicVar.event_enable);
                sci.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SCIPort_DataReceived);
                sci.SCIReceInt(1);
                this.BtnSwitch_event.Text = "关闭功能";//修改按钮上文字

            }
            else if(this.BtnSwitch_event.Text=="关闭功能")
            {
                Comm.DataReceiveOFF(ref PublicVar.event_close);

                this.BtnSwitch_event.Text = "开启功能";
            }



        }

        private void SCIPort_DataReceived(object sender,
         System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String str = String.Empty;
            bool Flag;//标记串口接收数据是否成功
            int len;//标记接收的数据的长度

            byte[] ch2 = new byte[2];
            sci = new SCI(PublicVar.g_SCIComNum, 115200);
            //ComDevice.Encoding = System.Text.Encoding.GetEncoding("GB2312");




            //调用串口接收函数,并返回结果
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
    }




      
    
}
