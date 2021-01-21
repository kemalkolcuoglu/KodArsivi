using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRGKBS.Varlik
{
    public class KisiIletisim
    {
        public int ID { get; set; }

        public int KisiID { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        public string MahalleKoy { get; set; }

        public string Adres { get; set; }

        public string PostaKodu { get; set; }

        public string EPosta { get; set; }

        public string Telefon1 { get; set; }

        public string Telefon2 { get; set; }

        public string TelefonGSM { get; set; }

        public string WebSitesi { get; set; }

        public string VergiDairesi { get; set; }

        public string VergiNo { get; set; }

        public string Ekleyen { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public string Duzenleyen { get; set; }

        public DateTime DuzenlemeTarihi { get; set; }
    }
}
