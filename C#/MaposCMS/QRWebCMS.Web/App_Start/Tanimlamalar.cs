using QRWebCMS.Web.Islemler;
using QRWebCMS.Web.Islemler.EkIslemler;
using QRWebCMS.Web.Models;

namespace QRWebCMS.Web.App_Start
{
    public static class Tanimlamalar
    {
        public static TemelIslemler<Form> formIslemleri = new TemelIslemler<Form>("form");
        public static TemelIslemler<Galeri> galeriIslemleri = new TemelIslemler<Galeri>("galeri");
        public static TemelIslemler<GaleriKategori> galeriKategoriIslemleri = new TemelIslemler<GaleriKategori>("galerikategori");
        public static TemelIslemler<GenelAyarlar> genelAyarlarIslemleri = new TemelIslemler<GenelAyarlar>("genelayarlar");
        public static TemelIslemler<TeknikAyarlar> teknikAyarlarIslemleri = new TemelIslemler<TeknikAyarlar>("teknikayarlar");
        public static TemelIslemler<Icerik> icerikIslemleri = new TemelIslemler<Icerik>("icerik");
        public static KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
        public static TemelIslemler<Menu> menuIslemleri = new TemelIslemler<Menu>("menu");
        public static MenuListeIslemleri menuListeIslemleri = new MenuListeIslemleri();
        public static TemelIslemler<Sayfa> sayfaIslemleri = new TemelIslemler<Sayfa>("sayfa");
        public static TemelIslemler<SayfaListe> sayfaListeIslemleri = new TemelIslemler<SayfaListe>("sayfaliste");
        public static TemelIslemler<Slide> slideIslemleri = new TemelIslemler<Slide>("slide");
        public static TemelIslemler<SlideKategori> slideKategoriIslemleri = new TemelIslemler<SlideKategori>("slidekategori");
        public static TemelIslemler<SosyalMedya> sosyalMedyaIslemleri = new TemelIslemler<SosyalMedya>("sosyalmedya");
        public static TemelIslemler<Urun> urunIslemleri = new TemelIslemler<Urun>("urun");
        public static TemelIslemler<UrunKategori> urunKategoriIslemleri = new TemelIslemler<UrunKategori>("urunkategori");
        public static TemelIslemler<Gorsel> gorselIslemleri = new TemelIslemler<Gorsel>("gorsel");
        public static TemelIslemler<Sayac> sayacIslemleri = new TemelIslemler<Sayac>("sayac");
    }
}