namespace RT_thread_pc_demo._04_Control
{
    partial class Mutex
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
            this.BtnSwitch_mutex = new System.Windows.Forms.Button();
            this.textBox_mutex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSwitch_mutex
            // 
            this.BtnSwitch_mutex.Location = new System.Drawing.Point(692, 197);
            this.BtnSwitch_mutex.Name = "BtnSwitch_mutex";
            this.BtnSwitch_mutex.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_mutex.TabIndex = 1;
            this.BtnSwitch_mutex.Text = "演示开始";
            this.BtnSwitch_mutex.UseVisualStyleBackColor = true;
            this.BtnSwitch_mutex.Click += new System.EventHandler(this.BtnSwitch_mutex_Click);
            // 
            // textBox_mutex
            // 
            this.textBox_mutex.Location = new System.Drawing.Point(53, 78);
            this.textBox_mutex.Multiline = true;
            this.textBox_mutex.Name = "textBox_mutex";
            this.textBox_mutex.ReadOnly = true;
            this.textBox_mutex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_mutex.Size = new System.Drawing.Size(547, 332);
            this.textBox_mutex.TabIndex = 17;
            // 
            // Mutex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_mutex);
            this.Controls.Add(this.BtnSwitch_mutex);
            this.Name = "Mutex";
            this.Size = new System.Drawing.Size(1007, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSwitch_mutex;
        private System.Windows.Forms.TextBox textBox_mutex;
    }
}
