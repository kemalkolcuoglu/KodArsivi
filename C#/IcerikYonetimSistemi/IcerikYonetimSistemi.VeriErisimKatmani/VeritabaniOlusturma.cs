using IcerikYonetimSistemi.VarlikKatmani;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.VeriErisimKatmani
{
	public class VeritabaniOlusturma : CreateDatabaseIfNotExists<DatabaseContext>
	{
		protected override void Seed(DatabaseContext context)
		{
			KullaniciYetki y1 = new KullaniciYetki
			{
				KullaniciYetkiAdi = "Site Yöneticisi"
			};

			KullaniciYetki y2 = new KullaniciYetki
			{
				KullaniciYetkiAdi = "İçerik Yöneticisi"
			};

			KullaniciYetki y3 = new KullaniciYetki
			{
				KullaniciYetkiAdi = "Kullanıcı"
			};

			Kullanici k1 = new Kullanici
			{
				KullaniciYetkiID = 1,
				KullaniciAdi = "admin",
				EPosta = "admin@admin.com",
				Sifre = "123456",
				KayitTarihi = DateTime.Now,
				Etkin = true,
				Guid = Guid.NewGuid(),
				KullaniciYetki = y1,
			};

			context.KullaniciYetki.AddRange(new List<KullaniciYetki>() { y1, y2, y3 });
			context.Kullanici.Add(k1);
			context.SaveChanges();

			Sayfalar s1 = new Sayfalar
			{
				SayfaBasligi = "Hakkımızda",
				Etkin = true
			};

			Sayfalar s2 = new Sayfalar
			{
				SayfaBasligi = "İletişim",
				Etkin = true
			};

			SayfaIcerik si1 = new SayfaIcerik
			{
				SayfaID = 1,
				Sayfa = s1,
				Etkin = true,
				DuzenlemeTarihi = DateTime.Now,
				OlusturmaTarihi = DateTime.Now,
				GosterimSirasi = 1,
				Baslik = "Hakkımızda",
				Detay = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
				Gorsel = "~/Images/hakkimizda1.jpg",
				Ikon = "<i class=\"icon-info-sign\"></i>",
				Yorum = false
			};

			context.Sayfalar.AddRange(new List<Sayfalar>() { s1, s2 });
			context.SayfaIcerik.Add(si1);
			context.SaveChanges();
		}
	}
}
