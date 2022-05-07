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
    public partial class Message_information : UserControl
    {
        public Message_information()
        {
            InitializeComponent();
            textBox_message_1.Text = OpenTextFile(PublicVar.path_message_1);
            textBox_message_2.Text = OpenTextFile(PublicVar.path_message_2);
        }
        public Main  frmMain;
        private void Btn_tomessage_Click(object sender, EventArgs e)
        {
         
 
            Message @message = new Message();
            Main.ClearPanel(this);//this获取父控件，panel_main
            Main.AddControlsToPanel(this, @message);
        }
        private string OpenTextFile(string path)
        {
            StreamReader textReader = new StreamReader(path);
            return textReader.ReadToEnd();

        }
    }
}
