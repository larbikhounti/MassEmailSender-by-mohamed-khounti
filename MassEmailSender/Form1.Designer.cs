namespace MassEmailSender
{
    partial class Form1
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
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.rtxt_Message = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.txtb_reciever = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(522, 382);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // txt_subject
            // 
            this.txt_subject.AcceptsReturn = true;
            this.txt_subject.Location = new System.Drawing.Point(155, 72);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(426, 20);
            this.txt_subject.TabIndex = 4;
            // 
            // rtxt_Message
            // 
            this.rtxt_Message.Location = new System.Drawing.Point(145, 107);
            this.rtxt_Message.Name = "rtxt_Message";
            this.rtxt_Message.Size = new System.Drawing.Size(436, 269);
            this.rtxt_Message.TabIndex = 5;
            this.rtxt_Message.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(129, 42);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(20, 13);
            this.dd.TabIndex = 9;
            this.dd.Text = "To";
            // 
            // txtb_reciever
            // 
            this.txtb_reciever.Location = new System.Drawing.Point(155, 39);
            this.txtb_reciever.Name = "txtb_reciever";
            this.txtb_reciever.Size = new System.Drawing.Size(178, 20);
            this.txtb_reciever.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 429);
            this.Controls.Add(this.txtb_reciever);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxt_Message);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.RichTextBox rtxt_Message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.TextBox txtb_reciever;
    }
}

