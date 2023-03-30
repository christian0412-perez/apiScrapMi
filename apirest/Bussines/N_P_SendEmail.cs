using System;
using System.Net;
using System.Net.Mail;

namespace capp_ScarperByUrl.Classes
{
    public class N_P_SendEmail
    {
        public void sendEmail(string _SUBJECT, string _HTMLBODY)
        {
            try
            {
                var fromAddress = new MailAddress("it.developer@mitechnologiesinc.com", "AutoBot by MI Technologies, Inc.");
                var toAddress = new MailAddress("vianey.ramirez@mitechnologiesinc.com.mx", "Vianey Ramirez");
                const string fromPassword = "devM1T2019!@?";
                string subject = _SUBJECT + DateTime.Now.ToShortDateString();
                string htmlBody = _HTMLBODY;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                //using (var message = new MailMessage(fromAddress, toAddress)
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = htmlBody
                })
                {
                    message.CC.Add(new MailAddress("pavel.torres@mitechnologiesinc.com", "Pavel Torres"));
                    message.CC.Add(new MailAddress("jovan.rodriguez@mitechnologiesinc.com", "Jovan Rodriguez"));
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                }
            }
            catch
            {
            }
        }

        public void sendEmailTo(string _SUBJECT, string _HTMLBODY,string _ToEmail, string[] _ListCCEmail )
        {
            try
            {
                var fromAddress = new MailAddress("it.developer@mitechnologiesinc.com", "AutoBot by MI Technologies, Inc.");
                var toAddress = new MailAddress(_ToEmail);
                const string fromPassword = "devM1T2019!@?";
                string subject = _SUBJECT + DateTime.Now.ToShortDateString();
                string htmlBody = _HTMLBODY;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                //using (var message = new MailMessage(fromAddress, toAddress)
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = htmlBody
                })
                {
                    foreach(var item in _ListCCEmail)
                    {
                        message.CC.Add(new MailAddress(item));
                    }
                    
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                }
            }
            catch
            {
            }
        }
    }
}
