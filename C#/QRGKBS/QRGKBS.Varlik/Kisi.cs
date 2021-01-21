using System;

namespace QRGKBS.Varlik
{
    public class Kisi
    {
        public int ID { get; set; }

        public string TCKNO { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Unvan { get; set; }

        public string BabaAdi { get; set; }

        public string AnneAdi { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Meslek { get; set; }

        public string OzelKod1 { get; set; }

        public string Fotograf { get; set; }

        public string Aciklama { get; set; }

        public string Ekleyen { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public string Duzenleyen { get; set; }

        public DateTime DuzenlemeTarihi { get; set; }
    }
}
