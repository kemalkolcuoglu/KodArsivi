using QRWebCMS.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace QRWebCMS.Web.Islemler.Helpers
{
    public class SmsHelper
    {
        private static TeknikAyarlar teknikAyarlar = App_Start.Tanimlamalar.teknikAyarlarIslemleri.Bul("1 = 1");
        public static bool SmsGonder(string telNo, string mesaj)
        {
            mesaj = mesaj.Replace(" ", "%20");
            return HttpGet("https://api.netgsm.com.tr/sms/send/get/?usercode=" + teknikAyarlar.SMSTelefonNo + "&password=" + teknikAyarlar.SMSSifresi + "&gsmno=" + telNo + "&message=" + mesaj + "&msgheader=" + teknikAyarlar.SMSMesajBasligi + "&dil=TR");
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