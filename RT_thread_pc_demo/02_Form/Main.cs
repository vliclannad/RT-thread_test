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
using RT_thread_pc_demo._04_Control;

namespace RT_thread_pc_demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SCI sci;

        //清除控件，并将控件集合添加进panel集合中
        static public void AddControlsToPanel(Control master, Control slave)
        {
            master.Controls.Clear();
            master.Controls.Add(slave);
        }
        //获取控件内包含的控件集合，并清除
        static public void ClearPanel(Control c)
        {
            c.Controls.Clear();
        }
        //主页面打开时自动加载
        private void Main_Load(object sender, EventArgs e)
        {
            MCU_connect mCU_Connect = new MCU_connect();
            Main_information main_Information = new Main_information();
            ClearPanel(panel_main);
            ClearPanel(panel_connect);
            AddControlsToPanel(panel_connect, mCU_Connect);
            AddControlsToPanel(panel_main,main_Information);
        }

        static public event EventHandler Menu_change;





        /**——————————————————————————菜单栏点击事件——————————————————————————**/
        private void Menu_main_Click(object sender, EventArgs e)
        {
            Main_information main_Information = new Main_information();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, main_Information);
            if(Menu_change != null)
            {
                Menu_change(sender, e);//触发该事件

            }


        }

        private void Menu_event_Click(object sender, EventArgs e)
        {
            Event_information event_Information = new Event_information();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, event_Information);
            if (Menu_change != null)
            {
                Menu_change(sender, e);

            }


        }

        private void Menu_message_Click(object sender, EventArgs e)
        {
            Message_information message_Information = new Message_information();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, message_Information);
            if (Menu_change != null)
            {
                Menu_change(sender, e);

            }

        }

        private void Menu_sp_Click(object sender, EventArgs e)
        {
            Sp_information sp_Information = new Sp_information();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, sp_Information);
            if (Menu_change != null)
            {
                Menu_change(sender, e);

            }
        }

        private void Menu_mutex_Click(object sender, EventArgs e)
        {
            Mutex_information mutex_Information = new Mutex_information();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, mutex_Information);
            if (Menu_change != null)
            {
                Menu_change(sender, e);

            }

        }
        private void Menu_delay_Click(object sender, EventArgs e)
        {
            Delay_informaiton delay_Informaiton = new Delay_informaiton();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, delay_Informaiton);
            if (Menu_change != null)
            {
                Menu_change(sender, e);

            }

        }

        private void Menu_help_Click(object sender, EventArgs e)
        {
            if (Menu_change != null)
            {
                Menu_change(sender, e);

            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr =MessageBox.Show("是否退出？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            if(dr ==DialogResult.OK)
            {
                if (Menu_change != null)
                {
                    Menu_change(sender, e);

                }

                e.Cancel = false;

            }
            else if (dr ==DialogResult.Cancel)
            {
                e.Cancel=true;

            }
        }



        /**——————————————————————————菜单栏点击事件——————————————————————————**/


    }

}
