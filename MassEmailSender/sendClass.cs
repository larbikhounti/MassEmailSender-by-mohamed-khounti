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
     
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        static string[] Scopes = { GmailService.Scope.GmailReadonly, GmailService.Scope.GmailInsert, GmailService.Scope.GmailSend };
        String  ApplicationName = "ok";

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

                Google.Apis.Gmail.v1.Data.Message m = service.Users.Messages.Send(newMsg, "me").Execute();
              
              
               
            }
            catch (Exception e)
            {

                throw;
            }
  

            Console.Read();
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
        public static string Base64UrlDecode(string input)
        {
            byte[] data = Convert.FromBase64String(input);
            string decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }


    }
   




}