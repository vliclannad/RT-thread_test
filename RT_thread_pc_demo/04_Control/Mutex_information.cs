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
    public partial class Mutex_information : UserControl
    {
        public Mutex_information()
        {
            InitializeComponent();
            textBox_mutex_1.Text = OpenTextFile(PublicVar.path_mutex_1);
            textBox_mutex_2.Text = OpenTextFile(PublicVar.path_mutex_2);
        }
        public Main  frmMain;
        private void Btn_tomutex_Click(object sender, EventArgs e)
        {
         
 
            Mutex mutex = new Mutex();
            Main.ClearPanel(this);//this获取父控件，panel_main
            Main.AddControlsToPanel(this, mutex);
        }
        private string OpenTextFile(string path)
        {
            StreamReader textReader = new StreamReader(path);
            return textReader.ReadToEnd();

        }
    }
}
