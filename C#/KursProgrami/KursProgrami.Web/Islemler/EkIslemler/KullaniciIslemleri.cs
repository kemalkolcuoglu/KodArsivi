using KursProgrami.Model;
using KursProgrami.Model.EkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace KursProgrami.Web.Islemler.EkIslemler
{
    public class KullaniciIslemleri : TemelIslemler<Kullanici>
    {
        public KullaniciIslemleri() : base("kullanici") { }

        public IslemKatmaniOgesi<Kullanici> KullaniciGirisIslemleri(KullaniciGirisi kullaniciGiris)
        {
            IslemKatmaniOgesi<Kullanici> iko = new IslemKatmaniOgesi<Kullanici>();
            List<Kullanici> kullanici;

            kullanici = VeriGetir(" TCKNO = '" + kullaniciGiris.TCKNO + "'");
            if (kullanici == null || kullanici.Count < 1)
            {
                iko.Hatalar.Add("Kayıtlı Kullanıcı Adı bulunmadı. Lütfen tekrar deneyiniz.");
                return iko;
            }

            kullanici = VeriGetir(" TCKNO = '" + kullaniciGiris.TCKNO + "' And Sifre = '" + kullaniciGiris.Sifre + "'");

            if (kullanici == null || kullanici.Count < 1)
                iko.Hatalar.Add("Girilen şifre hatalı. Lütfen tekrar deneyiniz.");
            else if (!kullanici[0].Etkin)
                iko.Hatalar.Add("Giriş için yetkiniz bulunmamaktadır. Lütfen yetkililer ile görüşünüz.");
            else
            {
                if (kullanici[0].Tur == "Egitmen")
                {
                    kullanici[0].SinifID = App_Start.Tanimlamalar.sinifIslemleri.Bul("EgitmenID = " + kullanici[0].KullaniciID).SinifID;
                    kullanici[0].DonemID = App_Start.Tanimlamalar.donemIslemleri.Bul("Etkin = 1").DonemID;

                    Egitmen egitmen = App_Start.Tanimlamalar.egitmenIslemleri.Bul("EgitmenID = " + kullanici[0].NitelikID);

                    kullanici[0].Ad = egitmen.Ad;
                    kullanici[0].Soyad = egitmen.Soyad;
                }
                else if (kullanici[0].Tur == "Yonetici")
                {
                    kullanici[0].DonemID = App_Start.Tanimlamalar.donemIslemleri.Bul("Etkin = 1").DonemID;
                    kullanici[0].SinifID = -1;
                }

                iko.Varlik = kullanici[0];
            }

            return iko;
        }
    }
}