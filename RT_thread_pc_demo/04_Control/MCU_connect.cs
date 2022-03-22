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
                label_connectstate.Text = "设备已连接";
            }
            if (PublicVar.g_Uflag == 0)
            {
                label_connectstate.Text = "设备未连接";
            }
        }
    }
}
