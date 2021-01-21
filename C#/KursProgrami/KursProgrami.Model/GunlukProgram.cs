using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class GunlukProgram
    {
        [Key]
        public int GunlukProgramID { get; set; }

        [Required, DisplayName("Kurs")]
        public int KursID { get; set; }

        [Required, DisplayName("Günlük Program Adı")]
        public string GunlukProgramAdi { get; set; }

        [DisplayName("Günlük Program Açıklaması")]
        public string GunlukProgramAciklamasi { get; set; }

        public bool Etkin { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime DuzenlemeTarihi { get; set; }
    }
}
