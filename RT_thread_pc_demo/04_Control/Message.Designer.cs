﻿namespace RT_thread_pc_demo._04_Control
{
    partial class Message
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
            this.BtnSwitch_message = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSwitch_message
            // 
            this.BtnSwitch_message.Location = new System.Drawing.Point(692, 197);
            this.BtnSwitch_message.Name = "BtnSwitch_message";
            this.BtnSwitch_message.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_message.TabIndex = 1;
            this.BtnSwitch_message.Text = "实验开始";
            this.BtnSwitch_message.UseVisualStyleBackColor = true;
            this.BtnSwitch_message.Click += new System.EventHandler(this.BtnSwitch_message_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(53, 78);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ReadOnly = true;
            this.textBox_message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_message.Size = new System.Drawing.Size(547, 332);
            this.textBox_message.TabIndex = 17;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.BtnSwitch_message);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(1007, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSwitch_message;
        private System.Windows.Forms.TextBox textBox_message;
    }
}
