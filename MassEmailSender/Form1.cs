﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MassEmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            EmailHandler emailhanlder = new EmailHandler();
            emailhanlder.email_send(txt_fromEmail.Text, txtb_reciever.Text, txt_subject.Text, rtxt_Message.Text, txtb_gmailpassword.Text);
        }

        public void send()
        {

        }
    }
}
