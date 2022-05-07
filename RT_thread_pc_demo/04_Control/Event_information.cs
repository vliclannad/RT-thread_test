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
using System.IO;

namespace RT_thread_pc_demo._04_Control
{
    public partial class Event_information : UserControl
    {
        public Event_information()
        {
            InitializeComponent();
            textBox_event_1.Text = OpenTextFile(PublicVar.path_event_1);
            textBox_event_2.Text = OpenTextFile(PublicVar.path_event_2);
        }
        public Main  frmMain;
        private void Btn_toevent_Click(object sender, EventArgs e)
        {
         
 
            Event @event = new Event();
            Main.ClearPanel(this);//this获取父控件，panel_main
            Main.AddControlsToPanel(this, @event);
        }
        private string OpenTextFile(string path)
        {
            StreamReader textReader = new StreamReader(path);
            return textReader.ReadToEnd();

        }
    }
}
