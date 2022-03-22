using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RT_thread_pc_demo._04_Control;

namespace RT_thread_pc_demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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
            ClearPanel(panel_connect);
            AddControlsToPanel(panel_connect, mCU_Connect);

        }


        /**——————————————————————————菜单栏点击事件——————————————————————————**/
        private void Menu_main_Click(object sender, EventArgs e)
        {

        }

        private void Menu_event_Click(object sender, EventArgs e)
        {
            Event_information event_Information = new Event_information();
            ClearPanel(panel_main);
            AddControlsToPanel(panel_main, event_Information);

        }

        private void Menu_message_Click(object sender, EventArgs e)
        {

        }

        private void Menu_sp_Click(object sender, EventArgs e)
        {

        }

        private void Menu_mutex_Click(object sender, EventArgs e)
        {

        }

        private void Menu_help_Click(object sender, EventArgs e)
        {

        }

        /**——————————————————————————菜单栏点击事件——————————————————————————**/


    }

}
