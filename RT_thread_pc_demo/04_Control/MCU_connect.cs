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
    public partial class MCU_connect : UserControl
    {
        public MCU_connect()
        {
            InitializeComponent();
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            Comm_Process Comm;
            Comm = new Comm_Process();
            Comm.FindSCI();
            if (PublicVar.g_Uflag == 1)
            {
                label_connectstate.Text = "已找到设备，串口号："+PublicVar.g_SCIComNum;
                Btn_connect.Text = "设备已连接";
                Btn_connect.Enabled = false;

            }
            if (PublicVar.g_Uflag == 0)
            {
                label_connectstate.Text = "未找到设备！";
                Btn_connect.Text = "重新连接";
            }
            
        }
    }
}
