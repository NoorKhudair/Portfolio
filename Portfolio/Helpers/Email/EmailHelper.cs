using MailKit.Net.Smtp;
using MimeKit;
using Portfolio.ViewModels;

namespace Portfolio.Helpers.Email
{
    public class EmailHelper : IEmailHelper
    {
        public void SendMessage(EmailViewModel model)
        {
            //Email Settings
            var FromEmail = "abdallahalzoul@gmail.com";
            var AppPassword = "cmpprestzohttvoo";
            var SMTPServer = "smtp.gmail.com";
            var SMTPPort = 465;

            // HTML Messages
            // Email Templates HTML 

            //Email Message
            var EmailMessage = new MimeMessage();
            EmailMessage.From.Add(new MailboxAddress("Abdallah Alzoul", FromEmail));
            EmailMessage.To.Add(MailboxAddress.Parse(model.EmailAddress));
            EmailMessage.Subject = model.Subject;
            EmailMessage.Body = new TextPart("plain") { Text = model.Message };
            // Attachments / cc
            // Send Email
            var client = new SmtpClient();
            client.Connect(SMTPServer, SMTPPort, MailKit.Security.SecureSocketOptions.SslOnConnect);
            client.Authenticate(FromEmail, AppPassword);
            client.Send(EmailMessage);
            client.Disconnect(true);

        }
    }
}
