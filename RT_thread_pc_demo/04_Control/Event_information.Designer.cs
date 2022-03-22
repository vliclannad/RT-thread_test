namespace RT_thread_pc_demo._04_Control
{
    partial class Event_information
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
            this.Btn_toevent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_toevent
            // 
            this.Btn_toevent.Location = new System.Drawing.Point(706, 247);
            this.Btn_toevent.Name = "Btn_toevent";
            this.Btn_toevent.Size = new System.Drawing.Size(99, 36);
            this.Btn_toevent.TabIndex = 0;
            this.Btn_toevent.Text = "演示页面";
            this.Btn_toevent.UseVisualStyleBackColor = true;
            this.Btn_toevent.Click += new System.EventHandler(this.Btn_toevent_Click);
            // 
            // Event_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_toevent);
            this.Name = "Event_information";
            this.Size = new System.Drawing.Size(1007, 554);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_toevent;
    }
}
