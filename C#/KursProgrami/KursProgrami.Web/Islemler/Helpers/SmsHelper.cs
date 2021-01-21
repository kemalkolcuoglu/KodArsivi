using KursProgrami.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace KursProgrami.Web.Islemler.Helpers
{
    public class SmsHelper
    {
        private static GenelAyarlar genelAyarlar = App_Start.Tanimlamalar.genelAyarlarIslemleri.Bul("1 = 1");
        public static bool SmsGonder(string telNo, string mesaj)
        {
            mesaj = mesaj.Replace(" ", "%20");
            return HttpGet("https://api.netgsm.com.tr/sms/send/get/?usercode=" + genelAyarlar.SMSTelefon + "&password=" + genelAyarlar.SMSSifre + "&gsmno=" + telNo + "&message=" + mesaj + "&msgheader=" + genelAyarlar.SMSBaslik + "&dil=TR");
        }

        private static bool HttpGet(string url)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            if (html == string.Empty)
                return false;

            return true;
        }

        public static bool TopluSms(List<string> TelNo, string mesaj)
        {
            string numaralar = String.Join(",", TelNo.ToArray());

            return SmsGonder(numaralar, mesaj);
        }
    }
}