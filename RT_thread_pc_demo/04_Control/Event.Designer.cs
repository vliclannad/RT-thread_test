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
            this.SuspendLayout();
            // 
            // BtnSwitch_event
            // 
            this.BtnSwitch_event.Location = new System.Drawing.Point(692, 197);
            this.BtnSwitch_event.Name = "BtnSwitch_event";
            this.BtnSwitch_event.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_event.TabIndex = 1;
            this.BtnSwitch_event.Text = "演示开始";
            this.BtnSwitch_event.UseVisualStyleBackColor = true;
            this.BtnSwitch_event.Click += new System.EventHandler(this.BtnSwitch_event_Click);
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(53, 78);
            this.textBox_event.Multiline = true;
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.ReadOnly = true;
            this.textBox_event.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_event.Size = new System.Drawing.Size(547, 332);
            this.textBox_event.TabIndex = 17;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_event);
            this.Controls.Add(this.BtnSwitch_event);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(1007, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSwitch_event;
        private System.Windows.Forms.TextBox textBox_event;
    }
}
