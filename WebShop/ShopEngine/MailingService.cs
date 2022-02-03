using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace WebShop.ShopEngine
{
    public class MailingService
    {
        public void CreateTestMessage(string email)
        {
            string to = email;
            string from = "julius1vaigauskas@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Receipt for purchase in WebShop";
            message.Body = @"Receipt for today's purchase attaced in file below thank you";   
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            var file = new Attachment(@"C:\Users\Dell\Documents\GitHub\WebShop\WebShop\CSVFIles\Check.txt");
            message.Attachments.Add(file);
            client.Port = 587;
            client.Credentials = new NetworkCredential(from, "--");
            client.EnableSsl = true;
            client.Send(message);
        }
    }
}
