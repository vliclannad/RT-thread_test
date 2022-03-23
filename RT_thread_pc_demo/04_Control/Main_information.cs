using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RT_thread_pc_demo._04_Control
{
    public partial class Main_information : UserControl
    {
        public Main_information()
        {
            InitializeComponent();
            textBox_main.Text = OpenTextFile(PublicVar.path_main);
        }

        private string OpenTextFile(string path)
        {
            StreamReader textReader=new StreamReader(path);
            return textReader.ReadToEnd();

        }
    }
}
