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
    public partial class Event_information : UserControl
    {
        public Event_information()
        {
            InitializeComponent();
        }
        public Main  frmMain;
        private void Btn_toevent_Click(object sender, EventArgs e)
        {
         
 
            Event @event = new Event();
            Main.ClearPanel(this);//this获取父控件，panel_main
            Main.AddControlsToPanel(this, @event);
        }
    }
}
