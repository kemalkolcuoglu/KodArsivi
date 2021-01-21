using KursProgrami.Model;
using KursProgrami.Web.Islemler;
using KursProgrami.Web.Islemler.EkIslemler;

namespace KursProgrami.Web.App_Start
{
    public static class Tanimlamalar
    {
        public static TemelIslemler<Ders> dersIslemleri = new TemelIslemler<Ders>("ders");
        public static TemelIslemler<Donem> donemIslemleri = new TemelIslemler<Donem>("donem");
        public static TemelIslemler<Egitmen> egitmenIslemleri = new TemelIslemler<Egitmen>("egitmen");
        public static TemelIslemler<GenelAyarlar> genelAyarlarIslemleri = new TemelIslemler<GenelAyarlar>("genelayarlar");
        public static TemelIslemler<GunlukProgram> gunlukProgramIslemleri = new TemelIslemler<GunlukProgram>("gunlukprogram");
        public static TemelIslemler<Il> ilIslemleri = new TemelIslemler<Il>("il");
        public static TemelIslemler<Ilce> ilceIslemleri = new TemelIslemler<Ilce>("ilce");
        public static KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
        public static TemelIslemler<Kurs> kursIslemleri = new TemelIslemler<Kurs>("kurs");
        public static TemelIslemler<Ogrenci> ogrenciIslemleri = new TemelIslemler<Ogrenci>("ogrenci");
        public static TemelIslemler<OgrenciDevamsizlik> ogrenciDevamsizlikIslemleri = new TemelIslemler<OgrenciDevamsizlik>("ogrencidevamsizlik");
        public static TemelIslemler<OgrenciIletisim> ogrenciIletisimIslemleri = new TemelIslemler<OgrenciIletisim>("ogrenciiletisim");
        public static TemelIslemler<OgrenciKursSinif> ogrenciKursSinifIslemleri = new TemelIslemler<OgrenciKursSinif>("ogrencikurssinif");
        public static TemelIslemler<OgrenciNot> ogrenciNotIslemleri = new TemelIslemler<OgrenciNot>("ogrencinot");
        public static TemelIslemler<OgrenciTipi> ogrenciTipiIslemleri = new TemelIslemler<OgrenciTipi>("ogrencitipi");
        public static TemelIslemler<SaatlikProgram> saatlikProgramIslemleri = new TemelIslemler<SaatlikProgram>("saatlikprogram");
        public static TemelIslemler<Sinif> sinifIslemleri = new TemelIslemler<Sinif>("sinif");
    }
}