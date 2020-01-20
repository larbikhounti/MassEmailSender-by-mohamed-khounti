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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.rtxt_Message = new System.Windows.Forms.RichTextBox();
            this.txb_time = new System.Windows.Forms.TextBox();
            this.statu = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.emails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_uploadfiles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_exite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(123)))), ((int)(((byte)(230)))));
            resources.ApplyResources(this.btn_send, "btn_send");
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(123)))), ((int)(((byte)(230)))));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Name = "btn_send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.AcceptsReturn = true;
            this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_subject, "txt_subject");
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.TextChanged += new System.EventHandler(this.txt_subject_TextChanged);
            // 
            // rtxt_Message
            // 
            this.rtxt_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtxt_Message, "rtxt_Message");
            this.rtxt_Message.Name = "rtxt_Message";
            // 
            // txb_time
            // 
            this.txb_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txb_time, "txb_time");
            this.txb_time.Name = "txb_time";
            // 
            // statu
            // 
            resources.ApplyResources(this.statu, "statu");
            this.statu.BackColor = System.Drawing.Color.White;
            this.statu.ForeColor = System.Drawing.Color.Red;
            this.statu.Name = "statu";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emails});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // emails
            // 
            resources.ApplyResources(this.emails, "emails");
            // 
            // btn_uploadfiles
            // 
            this.btn_uploadfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(123)))), ((int)(((byte)(230)))));
            resources.ApplyResources(this.btn_uploadfiles, "btn_uploadfiles");
            this.btn_uploadfiles.ForeColor = System.Drawing.Color.White;
            this.btn_uploadfiles.Name = "btn_uploadfiles";
            this.btn_uploadfiles.UseVisualStyleBackColor = false;
            this.btn_uploadfiles.Click += new System.EventHandler(this.btn_uploadfiles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // btn_exite
            // 
            this.btn_exite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_exite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btn_exite, "btn_exite");
            this.btn_exite.ForeColor = System.Drawing.Color.White;
            this.btn_exite.Name = "btn_exite";
            this.btn_exite.UseVisualStyleBackColor = false;
            this.btn_exite.Click += new System.EventHandler(this.btn_exite_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btn_exite;
            this.Controls.Add(this.btn_exite);
            this.Controls.Add(this.statu);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_uploadfiles);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txb_time);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rtxt_Message);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.RichTextBox rtxt_Message;
        private System.Windows.Forms.Button btn_uploadfiles;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader emails;
        private System.Windows.Forms.TextBox txb_time;
        private System.Windows.Forms.Label statu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_exite;
    }
}

