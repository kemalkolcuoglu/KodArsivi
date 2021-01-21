using System;

namespace QRGKBS.Varlik
{
    public class Kurum
    {
        public int ID { get; set; }

        public int BirlikID { get; set; }

        public DateTime KayitTarihi { get; set; }

        public int Tip { get; set; }

        public bool Etkin { get; set; }

        public string KurulusYili { get; set; }

        public string Ad { get; set; }

        public string KisaAd { get; set; }

        public string OzelKod1 { get; set; }

        public string Sehir { get; set; }

        public string Ilce { get; set; }

        public string MahalleKoy { get; set; }

        public string PostaKodu { get; set; }

        public string VergiNo { get; set; }

        public string VergiDairesi { get; set; }

        public string EPosta { get; set; }

        public string WebAdresi { get; set; }

        public string Telefon1 { get; set; }

        public string Telefon2 { get; set; }

        public string YetkiliAdSoyad1 { get; set; }

        public string YetkiliGSM1 { get; set; }

        public string YetkiliAdSoyad2 { get; set; }

        public string YetkiliGSM2 { get; set; }
    }
}
