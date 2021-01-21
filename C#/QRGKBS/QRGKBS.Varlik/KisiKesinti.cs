using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRGKBS.Varlik
{
    public class KisiKesinti
    {
        public int ID { get; set; }

        public int KisiID { get; set; }

        public float Stopaj{ get; set; }

        public float Bagkur { get; set; }

        public float GelirVergisi { get; set; }

        public float Borsa { get; set; }

        public float MeraFonu { get; set; }

        public string Ekleyen { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public string Duzenleyen { get; set; }

        public DateTime DuzenlemeTarihi { get; set; }
    }
}
