namespace RT_thread_pc_demo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_main = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_event = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_message = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_sp = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_mutex = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_main,
            this.Menu_event,
            this.Menu_message,
            this.Menu_sp,
            this.Menu_mutex,
            this.Menu_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_main
            // 
            this.Menu_main.Name = "Menu_main";
            this.Menu_main.Size = new System.Drawing.Size(56, 21);
            this.Menu_main.Text = "主页面";
            this.Menu_main.Click += new System.EventHandler(this.Menu_main_Click);
            // 
            // Menu_event
            // 
            this.Menu_event.Name = "Menu_event";
            this.Menu_event.Size = new System.Drawing.Size(68, 21);
            this.Menu_event.Text = "事件功能";
            this.Menu_event.Click += new System.EventHandler(this.Menu_event_Click);
            // 
            // Menu_message
            // 
            this.Menu_message.Name = "Menu_message";
            this.Menu_message.Size = new System.Drawing.Size(92, 21);
            this.Menu_message.Text = "消息队列功能";
            this.Menu_message.Click += new System.EventHandler(this.Menu_message_Click);
            // 
            // Menu_sp
            // 
            this.Menu_sp.Name = "Menu_sp";
            this.Menu_sp.Size = new System.Drawing.Size(80, 21);
            this.Menu_sp.Text = "信号量功能";
            this.Menu_sp.Click += new System.EventHandler(this.Menu_sp_Click);
            // 
            // Menu_mutex
            // 
            this.Menu_mutex.Name = "Menu_mutex";
            this.Menu_mutex.Size = new System.Drawing.Size(80, 21);
            this.Menu_mutex.Text = "互斥量功能";
            this.Menu_mutex.Click += new System.EventHandler(this.Menu_mutex_Click);
            // 
            // Menu_help
            // 
            this.Menu_help.Name = "Menu_help";
            this.Menu_help.Size = new System.Drawing.Size(44, 21);
            this.Menu_help.Text = "帮助";
            this.Menu_help.Click += new System.EventHandler(this.Menu_help_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Info;
            this.panel_main.Location = new System.Drawing.Point(0, 25);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1007, 554);
            this.panel_main.TabIndex = 1;
            // 
            // panel_connect
            // 
            this.panel_connect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_connect.Location = new System.Drawing.Point(0, 580);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(1007, 100);
            this.panel_connect.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel_connect);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "RT_thread演示系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Menu_main;
        private System.Windows.Forms.ToolStripMenuItem Menu_event;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_message;
        private System.Windows.Forms.ToolStripMenuItem Menu_sp;
        private System.Windows.Forms.ToolStripMenuItem Menu_mutex;
        private System.Windows.Forms.ToolStripMenuItem Menu_help;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_connect;
    }
}

