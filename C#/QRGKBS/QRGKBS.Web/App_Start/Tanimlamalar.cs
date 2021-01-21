using K_ORM.MSSQL;
using QRGKBS.Varlik;

namespace QRGKBS.Web.App_Start
{
    public static class Tanimlamalar
    {
        public static TemelIslemler<Kisi> kisiIslemleri = new TemelIslemler<Kisi>("kisi");
        public static TemelIslemler<KisiIletisim> kisiIletisimIslemleri = new TemelIslemler<KisiIletisim>("kisiiletisim");
        public static TemelIslemler<KisiKesinti> kisiKesintiIslemleri = new TemelIslemler<KisiKesinti>("kisikesinti");
        public static TemelIslemler<Kurum> kurumIslemleri = new TemelIslemler<Kurum>("kurum");
        public static TemelIslemler<Uyelik> uyelikIslemleri = new TemelIslemler<Uyelik>("uyelik");
    }
}