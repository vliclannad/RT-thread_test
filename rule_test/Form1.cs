using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rule_test
{
    public partial class Form1 : Form
    {

        static string lock_open="48534A0029000062679D6E30EEEC060101010001038400150000000662679D6E00000000000000";
        static string add_pw = "48534A003D00006267AC0572E7980001011702020384000C02000007D13132333435360000000000006267ABFB62678A60626E05C00000000000FF";
        static string change_pw = "48534A002C00006267990912EBF81601010500000384000C313437383532000000000000000B626798EA";
        static string delete_pw = "48534A003000006267AA2420EE041101011800000384000C00000002000B0000000000000000000000006267AA2E";
        static string stop_card = "48534A002500006267D69A2EE7803001011000000384000C0300000007D1006267D68B";
        static string enable_card = "48534A002500006267D6F105E6C82101011000000384000C0300000007D1016267D6D0";
        static string pw_time = "48534A003000006267D32B34EB383401011A00000384000D0207D16267D32B0162678A6062831DC0000000000000";
        Encoding a = Encoding.UTF8;
        public Form1()
        {
            InitializeComponent();
        }
        //开锁命令
        private void button1_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[lock_open.Length/2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(lock_open.Length/2)+2];

            rule_open = lock_open;
            


            rule_open=rule_open.Remove(14, 8);
            rule_open=rule_open.Insert(14, Gettime(300));                     
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i/2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f= string.Concat(rule_open,crc_open);
            for (int i = 0; i < rule_open_f.Length ; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f =Convert.ToBase64String(buffer_open1);
            textBox1.Text = rule_open_f.ToString();
        }


        //字符串十六进制转换
        private string StringToHexString(string s)
        {
            char[] values = s.ToCharArray();
            string hexOutput = null;
            int value;
            for(int i = 0; i < values.Length; i++)
            {
                 value = Convert.ToInt32(values[i]);
                 hexOutput += string.Format("{0:X}", value);
            }
            return hexOutput;
        }

        static   string Gettime(int t)//获取十六进制时间戳，t为当前时间加的秒数
        {
            long  datatime;
            string  datatime_16;
            datatime = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000 + t;//当前时间+5分钟的事件戳
            datatime_16 = datatime.ToString("x8");//转16进制，保留8位
            return datatime_16;
        }
        static int CRC16_MODBUS(byte[] puchMsg)//CRC校验码
                    {
                        int wCRCin = 0x0000; //初值
                        int wCPoly = 0x1021; //多项式
                        int wChar = 0;
                        int k = 0;
                        int usDataLen = puchMsg.Length;
                        while (usDataLen-- > 0)
                            {
                                wChar = puchMsg[k++];
                                wCRCin ^= wChar << 8;
                                for (int i = 0; i < 8; i++)
                {
                    if ((wCRCin & 0x8000) > 0)
                        wCRCin = (UInt16)((wCRCin << 1) ^ wCPoly);
                                        else
                        wCRCin = (UInt16)(wCRCin << 1);
                }
            }
                    return (wCRCin);
                    }
//添加新密码
        private void button2_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[add_pw.Length / 2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(add_pw.Length / 2) + 2];
            UTF8Encoding encoding = new UTF8Encoding();

            rule_open = add_pw;



            rule_open = rule_open.Remove(14, 8);
            rule_open = rule_open.Insert(14, Gettime(300));
            rule_open = rule_open.Remove(82, 8);
            rule_open = rule_open.Insert(82, Gettime(310));

           if(textBox9.Text.Length==6)
            {
                rule_open = rule_open.Remove(58, 12);
                rule_open = rule_open.Insert(58, StringToHexString(textBox9.Text));
            }
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i / 2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f = string.Concat(rule_open, crc_open);
            for (int i = 0; i < rule_open_f.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f = Convert.ToBase64String(buffer_open1);
            textBox2.Text = rule_open_f.ToString();

        }
//改变密码
        private void button3_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[change_pw.Length / 2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(change_pw.Length / 2) + 2];

            rule_open = change_pw;



            rule_open = rule_open.Remove(14, 8);
            rule_open = rule_open.Insert(14, Gettime(300));
            rule_open = rule_open.Remove(76, 8);
            rule_open = rule_open.Insert(76, Gettime(310));
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i / 2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f = string.Concat(rule_open, crc_open);
            for (int i = 0; i < rule_open_f.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f = Convert.ToBase64String(buffer_open1);
            textBox3.Text = rule_open_f.ToString();

        }
//删除密码
        private void button4_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[delete_pw.Length / 2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(delete_pw.Length / 2) + 2];

            rule_open = delete_pw;



            rule_open = rule_open.Remove(14, 8);
            rule_open = rule_open.Insert(14, Gettime(300));
            rule_open = rule_open.Remove(84, 8);
            rule_open = rule_open.Insert(84, Gettime(310));
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i / 2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f = string.Concat(rule_open, crc_open);
            for (int i = 0; i < rule_open_f.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f = Convert.ToBase64String(buffer_open1);
            textBox4.Text = rule_open_f.ToString();

        }
//禁用钥匙
        private void button5_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[stop_card.Length / 2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(stop_card.Length / 2) + 2];

            rule_open = stop_card;



            rule_open = rule_open.Remove(14, 8);
            rule_open = rule_open.Insert(14, Gettime(300));
            rule_open = rule_open.Remove(62, 8);
            rule_open = rule_open.Insert(62, Gettime(310));
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i / 2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f = string.Concat(rule_open, crc_open);
            for (int i = 0; i < rule_open_f.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f = Convert.ToBase64String(buffer_open1);
            textBox5.Text = rule_open_f.ToString();

        }
        //启用钥匙
        private void button6_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[enable_card.Length / 2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(enable_card.Length / 2) + 2];

            rule_open = enable_card;



            rule_open = rule_open.Remove(14, 8);
            rule_open = rule_open.Insert(14, Gettime(300));
            rule_open = rule_open.Remove(62, 8);
            rule_open = rule_open.Insert(62, Gettime(310));
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i / 2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f = string.Concat(rule_open, crc_open);
            for (int i = 0; i < rule_open_f.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f = Convert.ToBase64String(buffer_open1);
            textBox6.Text = rule_open_f.ToString();

        }
        //修改有效时间
        private void button7_Click(object sender, EventArgs e)
        {
            string rule_open;
            string crc_open;
            string rule_open_f;
            byte[] buffer_open = new byte[pw_time.Length / 2];//新建一个byte数组用来保存，长度是字符串长度的一半
            byte[] buffer_open1 = new byte[(pw_time.Length / 2) + 2];

            rule_open = pw_time;



            rule_open = rule_open.Remove(14, 8);
            rule_open = rule_open.Insert(14, Gettime(300));
            rule_open = rule_open.Remove(54, 8);
            rule_open = rule_open.Insert(54, Gettime(310));
            for (int i = 0; i < rule_open.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open[i / 2] = (byte)Convert.ToByte(rule_open.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            crc_open = CRC16_MODBUS(buffer_open).ToString("x4");
            rule_open_f = string.Concat(rule_open, crc_open);
            for (int i = 0; i < rule_open_f.Length; i += 2)//循环遍历字符串来赋值给byte数组
            {
                buffer_open1[i / 2] = (byte)Convert.ToByte(rule_open_f.Substring(i, 2), 16);//按2位来截取转换为byte数据
            }
            rule_open_f = Convert.ToBase64String(buffer_open1);
            textBox7.Text = rule_open_f.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://tool.lu/timestamp/");
        }

        //默认命令、字符位置（1.生效时间。2.添加密码。3.更改密码。4、钥匙有效期起始时间。5.钥匙有效期结束时间）、添加的新密码、修改的新密码、启

    }
}



