using System.Net;
using System.Net.Mail;

namespace PhPopovich.StaticHelpers
{
    public class EmailService
    {
        public static void Send(EmailModel emailModel)
        {
            var client = new SmtpClient("mail.hosting.reg.ru", 25);
            client.UseDefaultCredentials = true;
            client.Credentials = new NetworkCredential("support@ph-popovich.com", "8U_f41xu");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(emailModel.From);
            mailMessage.To.Add(emailModel.To);
            mailMessage.Body = emailModel.Body;
            mailMessage.Subject = emailModel.Subject;
            client.Send(mailMessage);
        }
    }
}
