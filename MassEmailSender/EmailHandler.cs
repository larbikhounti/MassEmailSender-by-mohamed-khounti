using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;



namespace MassEmailSender
{
    public class EmailHandler
    {


        public void email_send(String from,String to,String subject,String body,String password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;




                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
                SmtpServer.Send(mail);

            }

            catch (Exception e)
            {

              MessageBox.Show(e.Message); 
            }
            

        }

    }
}




