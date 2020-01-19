using System;
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
using System.Threading;
using System.IO;

namespace MassEmailSender
{
    public partial class Form1 : Form
    {
        public static String subjectt;
        public static String bodyy;
       public static  Thread sendthread = new Thread(send);


        public static int timeConverted;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_send_Click(object sender, EventArgs e)
        {
            // if the user is missing a form or a form is empty
            if (string.IsNullOrWhiteSpace(txb_time.Text) || string.IsNullOrWhiteSpace(txt_subject.Text) || string.IsNullOrWhiteSpace(rtxt_Message.Text))
            {
                MessageBox.Show("some of your inputs are empty fill the missing forms", "input error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                subjectt = txt_subject.Text;
                bodyy = rtxt_Message.Text;
                timeConverted = Convert.ToInt32(txb_time.Text) / 1000;

                sendthread.Start(); // start thread
              
                sendthread.IsBackground = true; 
                btn_send.Text = "Sending...";
                btn_send.Enabled = false;
                btn_Cancel.Enabled = true;
                do
                {
                   
                        MessageBox.Show("We Are Sending Messages Now...");
                    
                 
                 
                } while (sendthread.IsAlive);
                if (sendthread.IsAlive == false)
                {
                    MessageBox.Show("Messages Have Been Sent Successfully");
                    btn_send.Enabled = true;
                    btn_send.Text = "Send";
                    btn_Cancel.Enabled = false;
                }
            }
        }

        public static void send()
        {
 
                foreach (var item in sendClass.emails)
                {

                    
                    sendClass.sender(item, subjectt, bodyy);
                Console.WriteLine("thread");
                Thread.Sleep(timeConverted);
                
            }
          
        }

        private void btn_uploadfiles_Click(object sender, EventArgs e)
        {
            sendClass.AddEmails();
            listView1.Name = "emails";
            foreach (var item in sendClass.emails)
            {
                listView1.Items.Add(item);
            }
            emailscount.Text = "emails count : " + sendClass.emails.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_send.Enabled = true;
            btn_send.Text = "Send";
            btn_Cancel.Enabled = false;
            
        }

         private void txb_time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
