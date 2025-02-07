using System.Net;
using System.Net.Mail;


namespace Business_Layer
{
    public class Email
    {
        static public bool SendEmail(string SenderEmail, string SenderEmailAppPass, string ReceiverEmail, string Subject, string Body)
        {
            string FromEmail = SenderEmail;
            string AppPassword = SenderEmailAppPass;

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(FromEmail);
            msg.Subject = Subject;
            msg.To.Add(new MailAddress(ReceiverEmail));
            msg.Body = Body;
            msg.IsBodyHtml = false;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(FromEmail, AppPassword),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(msg);
            }
            catch { return false; }

            return true;
        }
    }
}
