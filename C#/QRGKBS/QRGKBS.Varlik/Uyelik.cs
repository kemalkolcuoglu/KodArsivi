using System;

namespace QRGKBS.Varlik
{
    public class Uyelik
    {
        public int ID { get; set; }

        public int KisiID { get; set; }

        public int BirlikID { get; set; }

        public int KoopID { get; set; }

        public int Durum { get; set; }

        public DateTime KayitTarihi { get; set; }

        public string UyeNo { get; set; }

        public int SigortaDurumu { get; set; }

        public int GirisYonKurTopNo { get; set; }

        public int GirisGenKurTopNo { get; set; }

        public int CikisYonKurTopNo { get; set; }

        public int CikisGenKurTopNo { get; set; }

        public DateTime CikisTarihi { get; set; }

        public string CikisNedeni { get; set; }

        public string Ekleyen { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public string Duzenleyen { get; set; }

        public DateTime DuzenlemeTarihi { get; set; }
    }
}
