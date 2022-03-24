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

namespace RT_thread_pc_demo._04_Control
{
    public partial class Delay_informaiton : UserControl
    {
        public Delay_informaiton()
        {
            InitializeComponent();
        }
        public Main  frmMain;
        private void Btn_todelay_Click(object sender, EventArgs e)
        {
         
 
            Delay delay = new Delay();
            Main.ClearPanel(this);//this获取父控件，panel_main
            Main.AddControlsToPanel(this, delay);
        }
    }
}
