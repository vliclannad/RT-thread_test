namespace RT_thread_pc_demo._04_Control
{
    partial class Message_information
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
            this.Btn_tomessage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_tomessage
            // 
            this.Btn_tomessage.Location = new System.Drawing.Point(706, 247);
            this.Btn_tomessage.Name = "Btn_tomessage";
            this.Btn_tomessage.Size = new System.Drawing.Size(99, 36);
            this.Btn_tomessage.TabIndex = 0;
            this.Btn_tomessage.Text = "演示页面";
            this.Btn_tomessage.UseVisualStyleBackColor = true;
            this.Btn_tomessage.Click += new System.EventHandler(this.Btn_tomessage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(103, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "消息队列功能介绍";
            // 
            // Message_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_tomessage);
            this.Name = "Message_information";
            this.Size = new System.Drawing.Size(1007, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_tomessage;
        private System.Windows.Forms.TextBox textBox1;
    }
}
