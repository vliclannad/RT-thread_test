namespace RT_thread_pc_demo._04_Control
{
    partial class Event
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSwitch_event = new System.Windows.Forms.Button();
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSwitch_event
            // 
            this.BtnSwitch_event.Location = new System.Drawing.Point(717, 254);
            this.BtnSwitch_event.Name = "BtnSwitch_event";
            this.BtnSwitch_event.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_event.TabIndex = 1;
            this.BtnSwitch_event.Text = "开始实验";
            this.BtnSwitch_event.UseVisualStyleBackColor = true;
            this.BtnSwitch_event.Click += new System.EventHandler(this.BtnSwitch_event_Click);
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(26, 42);
            this.textBox_event.Multiline = true;
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.ReadOnly = true;
            this.textBox_event.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_event.Size = new System.Drawing.Size(566, 360);
            this.textBox_event.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_event);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(19, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 424);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实验输出";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(399, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 28);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "实验二 事件实验";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSwitch_event);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(1007, 554);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSwitch_event;
        private System.Windows.Forms.TextBox textBox_event;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
