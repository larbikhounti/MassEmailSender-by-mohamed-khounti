using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MassEmailSender
{



    class sendClass
    {
        static public List<string> emails = new List<string>();
        static public int timeconverted;
        
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        static string[] Scopes = { GmailService.Scope.GmailReadonly, GmailService.Scope.GmailInsert, GmailService.Scope.GmailSend };
        String  ApplicationName = "ok";

        //add emails to the list
        public static void AddEmails()
        {
            //path of the file 
            String result = IfBrowseFileExist(BrowseFile());

            if (File.Exists(result))
            {
                string[] lines = File.ReadAllLines(result);
                foreach (string line in lines)
                    emails.Add(line);
                Console.WriteLine(emails);
            }
        
        }
        //clear List of emails 
        public static void ClearEmails()
        {
            emails.Clear();

        }
        //send emails 
        static  public  void sender(String to,String  subject,String body)
        {
           
            UserCredential credential;
            String ApplicationName = "test app";

           String plainText  = "To: "+to+",\r\n" +
                               "Subject: " + subject + "\r\n" +
                               "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                               "" + body + "";

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

               

            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            var newMsg = new Google.Apis.Gmail.v1.Data.Message();
            newMsg.Raw = sendClass.Base64UrlEncode(plainText.ToString());

            try
            {
                //send message with the email used 
                Google.Apis.Gmail.v1.Data.Message m = service.Users.Messages.Send(newMsg, "me").Execute();
                
              
              
               
            }
            catch (Exception)
            {

                throw;
            }
  

            Console.Read();
        }
        //file browser
        public static String BrowseFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Select Recipients",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
                
            }
            else
            {
                MessageBox.Show("Recipients Need To Be Selected", "file error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return "null";

        }
        //check path if exist
        public static String IfBrowseFileExist(String path)
        {
            if (File.Exists(path))
            {
                return path;
            }

            return "null";
        }
        //base 64 encoder
        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
        //base 64 decoder
        public static string Base64UrlDecode(string input)
        {
            byte[] data = Convert.FromBase64String(input);
            string decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }
        //show list view
        public static  void ListViewShower()
          
        {
      

        }
        // return time devided by 1000(millisecond)
        public static int timedevided()
        {
           int nexttime  =  timeconverted * 1000;
            return nexttime;
        }

    }
   




}