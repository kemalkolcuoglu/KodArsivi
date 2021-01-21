using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProgrami.Model
{
    public class DersKonu
    {
        [Key]
        public int DersKonuID { get; set; }
        public int SinifID { get; set; }
        public int DersID { get; set; }

        [DisplayName("Konu Adı")]
        public string KonuAdi { get; set; }
    }
}
