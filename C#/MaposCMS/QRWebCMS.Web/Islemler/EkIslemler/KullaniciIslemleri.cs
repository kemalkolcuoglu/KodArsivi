using QRWebCMS.Web.Areas.Yonetici.Models.EkModel;
using QRWebCMS.Web.Models;
using System.Collections.Generic;

namespace QRWebCMS.Web.Islemler.EkIslemler
{
    public class KullaniciIslemleri : TemelIslemler<Kullanici>
    {
        public KullaniciIslemleri() : base("kullanici") { }

        public IslemKatmaniOgesi<Kullanici> KullaniciGirisIslemleri(KullaniciGiris kullaniciGiris)
        {
            IslemKatmaniOgesi<Kullanici> iko = new IslemKatmaniOgesi<Kullanici>();
            List<Kullanici> kullanici;

            kullanici = VeriGetir(" KullaniciAdi = '" + kullaniciGiris.KullaniciAdi + "'");
            if (kullanici == null || kullanici.Count < 1)
            {
                iko.Hatalar.Add("Kayıtlı Kullanıcı Adı bulunmadı. Lütfen tekrar deneyiniz.");
                return iko;
            }

            kullanici = VeriGetir(" KullaniciAdi = '" + kullaniciGiris.KullaniciAdi + "' And Sifre = '" + kullaniciGiris.Sifre + "'");

            if (kullanici == null || kullanici.Count < 1)
                iko.Hatalar.Add("Girilen şifre hatalı. Lütfen tekrar deneyiniz.");
            else if (!kullanici[0].Etkin)
                iko.Hatalar.Add("Giriş için yetkiniz bulunmamaktadır. Lütfen yetkililer ile görüşünüz.");
            else
                iko.Varlik = kullanici[0];

            return iko;
        }
    }
}