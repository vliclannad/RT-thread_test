namespace RT_thread_pc._02_Form
{
    partial class Event
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
            this.textBox_event = new System.Windows.Forms.TextBox();
            this.BtnSwitch_event = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_event
            // 
            this.textBox_event.Location = new System.Drawing.Point(12, 161);
            this.textBox_event.Multiline = true;
            this.textBox_event.Name = "textBox_event";
            this.textBox_event.ReadOnly = true;
            this.textBox_event.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_event.Size = new System.Drawing.Size(434, 186);
            this.textBox_event.TabIndex = 17;
            // 
            // BtnSwitch_event
            // 
            this.BtnSwitch_event.Location = new System.Drawing.Point(519, 189);
            this.BtnSwitch_event.Name = "BtnSwitch_event";
            this.BtnSwitch_event.Size = new System.Drawing.Size(195, 75);
            this.BtnSwitch_event.TabIndex = 18;
            this.BtnSwitch_event.Text = "演示开始";
            this.BtnSwitch_event.UseVisualStyleBackColor = true;
            this.BtnSwitch_event.Click += new System.EventHandler(this.BtnSwitch_event_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSwitch_event);
            this.Controls.Add(this.textBox_event);
            this.Name = "Event";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_event;
        private System.Windows.Forms.Button BtnSwitch_event;
        private System.Windows.Forms.Button button1;
    }
}