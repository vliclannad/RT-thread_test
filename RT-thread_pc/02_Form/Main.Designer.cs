
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
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.BtnSwitch_event = new System.Windows.Forms.Button();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.tabSP = new System.Windows.Forms.TabPage();
            this.tabMutex = new System.Windows.Forms.TabPage();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEvent.SuspendLayout();
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
            this.tabEvent.Controls.Add(this.textBox_event);
            this.tabEvent.Controls.Add(this.BtnSwitch_event);
            this.tabEvent.Location = new System.Drawing.Point(4, 34);
            this.tabEvent.Name = "tabEvent";
            this.tabEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvent.Size = new System.Drawing.Size(1002, 642);
            this.tabEvent.TabIndex = 1;
            this.tabEvent.Text = "事件功能";
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(29, 161);
            this.textBox_event.Multiline = true;
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.Size = new System.Drawing.Size(574, 324);
            this.textBox_event.TabIndex = 2;
            // 
            // BtnSwitch_event
            // 
            this.BtnSwitch_event.Location = new System.Drawing.Point(638, 197);
            this.BtnSwitch_event.Name = "BtnSwitch_event";
            this.BtnSwitch_event.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_event.TabIndex = 0;
            this.BtnSwitch_event.Text = "开启功能";
            this.BtnSwitch_event.UseVisualStyleBackColor = true;
            this.BtnSwitch_event.Click += new System.EventHandler(this.BtnSwitch_event_Click);
            // 
            // tabMessage
            // 
            this.tabMessage.Location = new System.Drawing.Point(4, 34);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessage.Size = new System.Drawing.Size(1002, 642);
            this.tabMessage.TabIndex = 2;
            this.tabMessage.Text = "消息队列功能";
            this.tabMessage.UseVisualStyleBackColor = true;
            // 
            // tabSP
            // 
            this.tabSP.Location = new System.Drawing.Point(4, 34);
            this.tabSP.Name = "tabSP";
            this.tabSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabSP.Size = new System.Drawing.Size(1002, 642);
            this.tabSP.TabIndex = 3;
            this.tabSP.Text = "信息量功能";
            this.tabSP.UseVisualStyleBackColor = true;
            // 
            // tabMutex
            // 
            this.tabMutex.Location = new System.Drawing.Point(4, 34);
            this.tabMutex.Name = "tabMutex";
            this.tabMutex.Padding = new System.Windows.Forms.Padding(3);
            this.tabMutex.Size = new System.Drawing.Size(1002, 642);
            this.tabMutex.TabIndex = 4;
            this.tabMutex.Text = "互斥量功能";
            this.tabMutex.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "主页面";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEvent.ResumeLayout(false);
            this.tabEvent.PerformLayout();
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
        private System.Windows.Forms.Button BtnSwitch_event;
        public System.Windows.Forms.TextBox textBox_event;
    }
}