using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.Controllers.EmailSend
{
    internal class EmailController
    {
        public void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("kobitharankobi@gmail.com"); // உங்க Gmail
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("kobitharankobi@gmail.com", "@kobi2005"); // Gmail App Password
                smtp.EnableSsl = true;

                smtp.Send(mail);
               
            }
            catch (Exception ex)
            {
              
            }
        }
    }
}
