namespace RT_thread_pc_demo._04_Control
{
    partial class Sp
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
            this.BtnSwitch_sp = new System.Windows.Forms.Button();
            this.textBox_sp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSwitch_sp
            // 
            this.BtnSwitch_sp.Location = new System.Drawing.Point(692, 197);
            this.BtnSwitch_sp.Name = "BtnSwitch_sp";
            this.BtnSwitch_sp.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_sp.TabIndex = 1;
            this.BtnSwitch_sp.Text = "开始实验";
            this.BtnSwitch_sp.UseVisualStyleBackColor = true;
            this.BtnSwitch_sp.Click += new System.EventHandler(this.BtnSwitch_sp_Click);
            // 
            // textBox_sp
            // 
            this.textBox_sp.Location = new System.Drawing.Point(53, 78);
            this.textBox_sp.Multiline = true;
            this.textBox_sp.Name = "textBox_sp";
            this.textBox_sp.ReadOnly = true;
            this.textBox_sp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_sp.Size = new System.Drawing.Size(547, 332);
            this.textBox_sp.TabIndex = 17;
            // 
            // Sp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_sp);
            this.Controls.Add(this.BtnSwitch_sp);
            this.Name = "Sp";
            this.Size = new System.Drawing.Size(1007, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSwitch_sp;
        private System.Windows.Forms.TextBox textBox_sp;
    }
}
