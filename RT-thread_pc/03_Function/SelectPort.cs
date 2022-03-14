using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RT_thread_pc._03_Function;
using System.Threading;

namespace KL36_Demo_Sys._04_Control
{
    public partial class UC_SelectUart
    {
        SCI sci;
        string[] SCIPorts;
        byte[] recvData = new byte[100];
        byte[] userShake = { (byte)10, (byte)'K', (byte)'L', (byte)'3', (byte)'6', (byte)'?' }; //与终端握手帧数据
        byte[] finshShake = { (byte)7, (byte)'o', (byte)'k' };

        public UC_SelectUart()
        {
            SCIPorts = SCI.SCIGetPorts();
        }
        public void FindSCI()
        {
            for (int i = 0; i < SCIPorts.Length; i++)
            {
                sci = new SCI(SCIPorts[i], 115200);
                if (sci.SCIOpen())
                {
                    sci.SCISendFrameData(ref userShake);

                    Thread.Sleep(500);
                    if (sci.SCIReceiveData(ref recvData))
                    {

                        if (recvData.Length == 0 || !System.Text.Encoding.Default.GetString(recvData).Contains("I am an KL36"))
                        {
                            sci.Close();
                            continue;
                        }
                        if (System.Text.Encoding.Default.GetString(recvData).Contains("I am an KL36"))   //记录UART_User串口的Com号
                        {
                            PublicVar.g_SCIComNum = SCIPorts[i];
                            sci.Close();
                            break;                                                              //找到UART_User串口后，跳出循环
                        }
                    }
                }
            }
        }

        private void UC_SelectUart_Load(object sender, EventArgs e)
        {
            label2.Text += "已找到" + Convert.ToString(SCIPorts.Length) + "个串口\n";
            for (int i = 0; i < SCIPorts.Length; i++)
            {
                label2.Text += "          " + SCIPorts[i] + "\n";
            }

            if (SCIPorts.Length >= 1)
            {
                FindSCI();
                label2.Text += "已找到设备\n";
                if (PublicVar.g_SCIComNum == null)
                {
                    MessageBox.Show("有设备但无用户串口，请连接", "错误提示");
                    PublicVar.g_Uflag = -1;
                }
                else
                {
                    label2.Text += "开始打开串口...\n已自动选择用户串口：" + PublicVar.g_SCIComNum;
                    comboBox1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("无可用串口，请检查！", "错误提示");
                PublicVar.g_Uflag = -1;
            }

        }
    }


}

