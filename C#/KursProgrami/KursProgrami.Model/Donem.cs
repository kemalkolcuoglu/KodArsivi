using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Donem
    {
        [Key]
        public int DonemID { get; set; }

        public int KursID { get; set; }

        [DisplayName("Dönem Adı"), MaxLength(25)]
        public string DonemAdi { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        public DateTime BaslangicTarihi { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime BitisTarihi { get; set; }

        public int Konteyjan { get; set; }

        public bool Etkin { get; set; }
    }
}
