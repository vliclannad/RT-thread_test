using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RT_thread_pc_demo._04_Control
{
    public partial class Mutex : UserControl
    {
        SCI sci;

        delegate void handleinterfaceupdatedelegate(Object textbox,
                                                    string text);
        public Mutex()
        {
            InitializeComponent();
        }

        private void BtnSwitch_mutex_Click(object sender, EventArgs e)
        {
            Comm_Process comm = new Comm_Process();
            Button button = (Button)sender;
            PublicVar.g_TextBox = this.textBox_mutex;
            if (PublicVar.g_SCIComNum == null)
            {
                DialogResult dr = MessageBox.Show("    设备未连接！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (button.Text == "开始实验")
                {
                    string a = "开始实验";
                    send_command(ref PublicVar.mutex_enable, ref a);
                    Main.Menu_change += mcu_result;

                    button.Text = "结束实验";//修改按钮上文字

                }
                else if (button.Text == "结束实验")
                {
                    string b = "结束实验";
                    send_command(ref PublicVar.mutex_close, ref b);

                    button.Text = "开始实验";
                }
            }

        }

        public void send_command(ref byte[] SendArray, ref string a)
        {

            if (a == "开始实验")
            {
                sci = new SCI(PublicVar.g_SCIComNum, PublicVar.g_SCIBaudRate);
                if (sci.SCIOpen())
                {
                    //sci.SCIOpen();
                    sci.SCISendData(ref SendArray);
                    sci.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SCIPort_DataReceived);
                    sci.SCIReceInt(1);
                }

            }
            else if (a == "结束实验")
            {
                sci.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.SCIPort_DataReceived);
                if (sci.IsOpen)
                {
                    sci.SCISendData(ref SendArray);
                    sci.SCIClose();
                }
            }
        }

        private void SCIPort_DataReceived(object sender,
          System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String str = String.Empty;
            bool Flag;//标记串口接收数据是否成功
            int len;//标记接收的数据的长度

            byte[] ch2 = new byte[2];




            //调用串口接收函数,并返回结果
            Flag = sci.SCIReceiveData(ref PublicVar.g_ReceiveByteArray);
            if (Flag == true)//串口接收数据成功
            {
                len = PublicVar.g_ReceiveByteArray.Length;
                //对于字符串形式,考虑到可能有汉字,
                //直接调用系统定义的函数,处理整个字符串
                str = Encoding.GetEncoding("GB2312").GetString(PublicVar.g_ReceiveByteArray);

                SCIUpdateRevtxtbox(PublicVar.g_TextBox, str);

                //sci.Close();

            }
        }

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
        private void mcu_result(object sender, EventArgs e)
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
