using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluModulFiyatHesaplama
{
    class Modul
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int KursID { get; set; } // 0 - Ortak, 1 - Ağ, 2 - Siber
        public decimal Ucret { get; set; }
        public int IndirimOrani { get; set; }
        public bool Indirim { get; set; }
        public bool Aktif { get; set; }
    }
}
