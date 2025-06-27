using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

namespace C__UnicomManagementSystem.Controllers.EmailSend
{
    internal class EmailController
    {
        public  string SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("youkissme10time@gmail.com"));
                email.To.Add(MailboxAddress.Parse(toEmail));
                email.Subject = subject;

                email.Body = new TextPart("plain")
                {
                    Text = body
                };

                using (var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect); // Use SSL
                    smtp.Authenticate("youkissme10time@gmail.com", "jcnyueufvwrlqnup"); // App password only
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return "Email Sent Successfully!";
            }
            catch (Exception ex)
            {
                return $"Email Failed: {ex.Message}";
            }
           

             
        }
    }
}
