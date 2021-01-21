using IcerikYonetimSistemi.OrtakKatman.Helpers;
using IcerikYonetimSistemi.VarlikKatmani;
using IcerikYonetimSistemi.VarlikKatmani.EkModel;
using System;

namespace IcerikYonetimSistemi.IslemKatmani
{
	public class KullaniciIslemleri : TemelIslemler<Kullanici>
	{
		public IslemKatmaniOgesi<Kullanici> KullaniciGirisIslemleri(KullaniciGiris kullaniciGiris)
		{
			IslemKatmaniOgesi<Kullanici> iko = new IslemKatmaniOgesi<Kullanici>();
			Kullanici kullanici = Bul(x => x.EPosta == kullaniciGiris.EPosta && x.Sifre == kullaniciGiris.Sifre);
			if (kullanici == null)
				iko.Hatalar.Add("Girilen bilgiler hatalı!");
			else
				iko.Varlik = kullanici;

			return iko;
		}

		public IslemKatmaniOgesi<Kullanici> KullaniciyiGetir(int id)
		{
			IslemKatmaniOgesi<Kullanici> iko = new IslemKatmaniOgesi<Kullanici>
			{
				Varlik = Bul(x => x.KullaniciID == id)
			};

			if (iko.Varlik == null)
				iko.Hatalar.Add("Kullanıcı Bulunamadı!");
			return iko;
		}

		public IslemKatmaniOgesi<Kullanici> KullaniciKayitIslemleri(KullaniciKayit kullaniciKayit)
		{
			Kullanici kullanici = Bul(x => x.EPosta == kullaniciKayit.EPosta);
			IslemKatmaniOgesi<Kullanici> iko = new IslemKatmaniOgesi<Kullanici>();
			if (kullanici != null)
				iko.Hatalar.Add("Girilen E-Posta adresi kayıtlı!");
			else
			{
				Kullanici k = new Kullanici()
				{
					KullaniciYetkiID = 3,
					KullaniciAdi = kullaniciKayit.KullaniciAdi,
					EPosta = kullaniciKayit.EPosta,
					Sifre = kullaniciKayit.Sifre,
					Etkin = false,
					KayitTarihi = DateTime.Now,
					Guid = Guid.NewGuid()
				};

				int sonuc = Ekle(k);
				if (sonuc > 0)
				{
					iko.Varlik = k;

					string siteUri = ConfigHelper.Get<string>("SiteRootUri");
					string aktivasyonUri = $"{siteUri}/Ev/KullaniciAktivasyonu/{k.Guid}";
					string mailBody = $"Merhaba {k.KullaniciAdi}; </br></br> Hesabınızı aktifleştirmek için <a href='{aktivasyonUri} target='_blank'>tıklayınız.";
					MailHelper.SendMail(mailBody,k.EPosta,"Kullanıcı Aktivasyonu");
				}
			}

			return iko;
		}

		public IslemKatmaniOgesi<Kullanici> KullaniciAktivasyonIslemleri(Guid aktivasyonId)
		{
			IslemKatmaniOgesi<Kullanici> iko = new IslemKatmaniOgesi<Kullanici>();
			iko.Varlik = Bul(x => x.Guid == aktivasyonId);

			if(iko.Varlik != null)
			{
				if (iko.Varlik.Etkin)
				{
					iko.Hatalar.Add("Kullanıcı çoktan aktive edildi!");
					return iko;
				}

				iko.Varlik.Etkin = true;
				Guncelle(iko.Varlik);
			}
			else
				iko.Hatalar.Add("Böyle bir kullanıcı bulunamadı!");

			return iko;
		}
	}
}
