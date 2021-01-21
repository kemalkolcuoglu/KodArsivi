using QRWebCMS.Web.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace QRWebCMS.Web.Islemler.Helpers
{
    public class MailHelper
    {
        private static TeknikAyarlar teknikAyarlar = App_Start.Tanimlamalar.teknikAyarlarIslemleri.Bul("1 = 1");
        public static bool SendMail(string body, string to, string subject, bool isHtml = true)
        {
            return SendMail(body, new List<string> { to }, subject, isHtml);
        }

        public static bool SendMail(string body, List<string> to, string subject, bool isHtml = true)
        {
            bool result = false;

            try
            {
                var message = new MailMessage();
                //message.From = new MailAddress(ConfigHelper.Get<string>("MailUser"));
                message.From = new MailAddress(teknikAyarlar.EPostaAdresi);

                to.ForEach(x =>
                {
                    message.To.Add(new MailAddress(x));
                });

                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = isHtml;

                //using (var smtp = new SmtpClient(ConfigHelper.Get<string>("MailHost"),ConfigHelper.Get<int>("MailPort")))
                using (var smtp = new SmtpClient(teknikAyarlar.EPostaSunucusu, Convert.ToInt32(teknikAyarlar.EPostaPort)))
                {
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(teknikAyarlar.EPostaAdresi, teknikAyarlar.EPostaSifresi);
                    //smtp.Credentials = new NetworkCredential(ConfigHelper.Get<string>("MailUser"),ConfigHelper.Get<string>("MailPass");

                    smtp.Send(message);
                    result = true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            return result;
        }
    }
}