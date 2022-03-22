
namespace RT_thread_pc._02_Form
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_connectstate = new System.Windows.Forms.Label();
            this.mcu_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEvent = new System.Windows.Forms.TabPage();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.BtnSwitch_message = new System.Windows.Forms.Button();
            this.tabSP = new System.Windows.Forms.TabPage();
            this.textBox_sp = new System.Windows.Forms.TextBox();
            this.BtnSwitch_sp = new System.Windows.Forms.Button();
            this.tabMutex = new System.Windows.Forms.TabPage();
            this.textBox_mutex = new System.Windows.Forms.TextBox();
            this.BtnSwitch_mutex = new System.Windows.Forms.Button();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.BtnSwitch_event = new System.Windows.Forms.Button();
            this.to_event = new System.Windows.Forms.Button();
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEvent.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tabSP.SuspendLayout();
            this.tabMutex.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabEvent);
            this.tabControl1.Controls.Add(this.tabMessage);
            this.tabControl1.Controls.Add(this.tabSP);
            this.tabControl1.Controls.Add(this.tabMutex);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(50, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 680);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Bisque;
            this.tabMain.Controls.Add(this.panel1);
            this.tabMain.Location = new System.Drawing.Point(4, 34);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1002, 642);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "主页面";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label_connectstate);
            this.panel1.Controls.Add(this.mcu_connect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 125);
            this.panel1.TabIndex = 1;
            // 
            // label_connectstate
            // 
            this.label_connectstate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connectstate.AutoSize = true;
            this.label_connectstate.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_connectstate.Location = new System.Drawing.Point(444, 37);
            this.label_connectstate.Name = "label_connectstate";
            this.label_connectstate.Size = new System.Drawing.Size(162, 39);
            this.label_connectstate.TabIndex = 3;
            this.label_connectstate.Text = "设备未连接";
            // 
            // mcu_connect
            // 
            this.mcu_connect.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcu_connect.Location = new System.Drawing.Point(716, 38);
            this.mcu_connect.Name = "mcu_connect";
            this.mcu_connect.Size = new System.Drawing.Size(152, 38);
            this.mcu_connect.TabIndex = 2;
            this.mcu_connect.Text = "连接设备";
            this.mcu_connect.UseVisualStyleBackColor = true;
            this.mcu_connect.Click += new System.EventHandler(this.mcu_connect_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(266, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接状态：";
            // 
            // tabEvent
            // 
            this.tabEvent.BackColor = System.Drawing.Color.Bisque;
            this.tabEvent.Controls.Add(this.panel2);
            this.tabEvent.Location = new System.Drawing.Point(4, 34);
            this.tabEvent.Name = "tabEvent";
            this.tabEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvent.Size = new System.Drawing.Size(1002, 642);
            this.tabEvent.TabIndex = 1;
            this.tabEvent.Text = "事件功能";
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.textBox_message);
            this.tabMessage.Controls.Add(this.BtnSwitch_message);
            this.tabMessage.Location = new System.Drawing.Point(4, 34);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessage.Size = new System.Drawing.Size(1002, 642);
            this.tabMessage.TabIndex = 2;
            this.tabMessage.Text = "消息队列功能";
            this.tabMessage.UseVisualStyleBackColor = true;
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(54, 182);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ReadOnly = true;
            this.textBox_message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_message.Size = new System.Drawing.Size(574, 324);
            this.textBox_message.TabIndex = 17;
            // 
            // BtnSwitch_message
            // 
            this.BtnSwitch_message.Location = new System.Drawing.Point(634, 218);
            this.BtnSwitch_message.Name = "BtnSwitch_message";
            this.BtnSwitch_message.Size = new System.Drawing.Size(246, 88);
            this.BtnSwitch_message.TabIndex = 0;
            this.BtnSwitch_message.Text = "演示开始";
            this.BtnSwitch_message.UseVisualStyleBackColor = true;
            this.BtnSwitch_message.Click += new System.EventHandler(this.BtnSwitch_message_Click);
            // 
            // tabSP
            // 
            this.tabSP.Controls.Add(this.textBox_sp);
            this.tabSP.Controls.Add(this.BtnSwitch_sp);
            this.tabSP.Location = new System.Drawing.Point(4, 34);
            this.tabSP.Name = "tabSP";
            this.tabSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSP.Size = new System.Drawing.Size(1002, 642);
            this.tabSP.TabIndex = 3;
            this.tabSP.Text = "信息量功能";
            this.tabSP.UseVisualStyleBackColor = true;
            // 
            // textBox_sp
            // 
            this.textBox_sp.Location = new System.Drawing.Point(88, 159);
            this.textBox_sp.Multiline = true;
            this.textBox_sp.Name = "textBox_sp";
            this.textBox_sp.ReadOnly = true;
            this.textBox_sp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_sp.Size = new System.Drawing.Size(574, 324);
            this.textBox_sp.TabIndex = 19;
            // 
            // BtnSwitch_sp
            // 
            this.BtnSwitch_sp.Location = new System.Drawing.Point(668, 195);
            this.BtnSwitch_sp.Name = "BtnSwitch_sp";
            this.BtnSwitch_sp.Size = new System.Drawing.Size(246, 88);
            this.BtnSwitch_sp.TabIndex = 18;
            this.BtnSwitch_sp.Text = "演示开始";
            this.BtnSwitch_sp.UseVisualStyleBackColor = true;
            this.BtnSwitch_sp.Click += new System.EventHandler(this.BtnSwitch_sp_Click);
            // 
            // tabMutex
            // 
            this.tabMutex.Controls.Add(this.textBox_mutex);
            this.tabMutex.Controls.Add(this.BtnSwitch_mutex);
            this.tabMutex.Location = new System.Drawing.Point(4, 34);
            this.tabMutex.Name = "tabMutex";
            this.tabMutex.Padding = new System.Windows.Forms.Padding(3);
            this.tabMutex.Size = new System.Drawing.Size(1002, 642);
            this.tabMutex.TabIndex = 4;
            this.tabMutex.Text = "互斥量功能";
            this.tabMutex.UseVisualStyleBackColor = true;
            // 
            // textBox_mutex
            // 
            this.textBox_mutex.Location = new System.Drawing.Point(88, 159);
            this.textBox_mutex.Multiline = true;
            this.textBox_mutex.Name = "textBox_mutex";
            this.textBox_mutex.ReadOnly = true;
            this.textBox_mutex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_mutex.Size = new System.Drawing.Size(574, 324);
            this.textBox_mutex.TabIndex = 19;
            // 
            // BtnSwitch_mutex
            // 
            this.BtnSwitch_mutex.Location = new System.Drawing.Point(668, 195);
            this.BtnSwitch_mutex.Name = "BtnSwitch_mutex";
            this.BtnSwitch_mutex.Size = new System.Drawing.Size(246, 88);
            this.BtnSwitch_mutex.TabIndex = 18;
            this.BtnSwitch_mutex.Text = "演示开始";
            this.BtnSwitch_mutex.UseVisualStyleBackColor = true;
            this.BtnSwitch_mutex.Click += new System.EventHandler(this.BtnSwitch_mutex_Click);
            // 
            // tabHelp
            // 
            this.tabHelp.Location = new System.Drawing.Point(4, 34);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(1002, 642);
            this.tabHelp.TabIndex = 5;
            this.tabHelp.Text = "帮助";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // BtnSwitch_event
            // 
            this.BtnSwitch_event.Location = new System.Drawing.Point(644, 146);
            this.BtnSwitch_event.Name = "BtnSwitch_event";
            this.BtnSwitch_event.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_event.TabIndex = 0;
            this.BtnSwitch_event.Text = "演示开始";
            this.BtnSwitch_event.UseVisualStyleBackColor = true;
            this.BtnSwitch_event.Click += new System.EventHandler(this.BtnSwitch_event_Click);
            // 
            // to_event
            // 
            this.to_event.Location = new System.Drawing.Point(644, 296);
            this.to_event.Name = "to_event";
            this.to_event.Size = new System.Drawing.Size(196, 64);
            this.to_event.TabIndex = 17;
            this.to_event.Text = "实验页面";
            this.to_event.UseVisualStyleBackColor = true;
            this.to_event.Click += new System.EventHandler(this.to_event_Click);
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(47, 62);
            this.textBox_event.Multiline = true;
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.ReadOnly = true;
            this.textBox_event.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_event.Size = new System.Drawing.Size(547, 332);
            this.textBox_event.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_event);
            this.panel2.Controls.Add(this.to_event);
            this.panel2.Controls.Add(this.BtnSwitch_event);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 642);
            this.panel2.TabIndex = 18;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 25);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "主页面";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEvent.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.tabMessage.PerformLayout();
            this.tabSP.ResumeLayout(false);
            this.tabSP.PerformLayout();
            this.tabMutex.ResumeLayout(false);
            this.tabMutex.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabEvent;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.TabPage tabSP;
        private System.Windows.Forms.TabPage tabMutex;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mcu_connect;
        private System.Windows.Forms.Label label_connectstate;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button BtnSwitch_message;
        private System.Windows.Forms.TextBox textBox_sp;
        private System.Windows.Forms.Button BtnSwitch_sp;
        private System.Windows.Forms.TextBox textBox_mutex;
        private System.Windows.Forms.Button BtnSwitch_mutex;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_event;
        private System.Windows.Forms.Button to_event;
        private System.Windows.Forms.Button BtnSwitch_event;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}