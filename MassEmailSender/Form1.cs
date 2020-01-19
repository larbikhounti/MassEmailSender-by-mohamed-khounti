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
                Console.WriteLine(DateTime.Now);
                subjectt = txt_subject.Text;
                bodyy = rtxt_Message.Text;
                timeConverted = Convert.ToInt32(txb_time.Text);
                sendClass.timeconverted = timeConverted;


                sendthread.Start(); // start thread
              
                sendthread.IsBackground = true; 
                btn_send.Text = "Sending...";
                btn_send.Enabled = false;
                btn_Cancel.Enabled = true;
                statu.ForeColor = Color.Green;
                 statu.Text = "Sending";
                do
                {
                    DialogResult dialogResult = MessageBox.Show("we are sending messages", "Message state", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        statu.ForeColor = Color.Red;
                        statu.Text = "Ready";
                        sendthread.Abort();
                    }
                } while (sendthread.IsAlive == true);          
                if (sendthread.IsAlive == false)
                {
                    MessageBox.Show("Task ended ");
                    btn_send.Enabled = true;
                    btn_send.Text = "Send";
                    btn_Cancel.Enabled = false;


                }
            }
        }

        public static void send()
        {

            for (int i = 0; i < sendClass.emails.Count; i++)

            {
                sendClass.sender(sendClass.emails[i], subjectt, bodyy);
                Console.WriteLine("thread");
                
                Thread.Sleep(sendClass.timedevided());
                
               
                
            }
   
        }

        private void btn_uploadfiles_Click(object sender, EventArgs e)
        {
            sendClass.ClearEmails();
            sendClass.AddEmails();
            listView1.Items.Clear();
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
            statu.ForeColor = Color.Red;
            statu.Text = "Ready";
            sendthread.Abort();
            

        }

         private static  void txb_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void emailprogress_Click(object sender, EventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        private void txb_time_TextChanged_1(object sender, EventArgs e)
        {

        }
  

    }
}
