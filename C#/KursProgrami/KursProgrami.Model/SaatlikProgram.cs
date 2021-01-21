using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class SaatlikProgram
    {
        [Key]
        public int SaatlikProgramID { get; set; }

        [Required, DisplayName("Kurs")]
        public int KursID { get; set; }

        [DisplayName("Eğitmen")]
        public int EgitmenID { get; set; }

        [Required, DisplayName("Günlük Program")]
        public int GunlukProgramID { get; set; }

        [Required, DisplayName("Başlangıç Saati")]
        public string BaslangicSaati { get; set; }

        [DisplayName("Bitiş Saati")]
        public string BitisSaati { get; set; }

        [Required, DisplayName("Program Adı")]
        public string ProgramAdi { get; set; }

        [DisplayName("Program Açıklaması")]
        public string ProgramAciklamasi { get; set; }

        [DisplayName("Not Değerlendirme")]
        public bool NotDegerlendirme { get; set; }

        [DisplayName("Yoklama Zorunluluğu")]
        public bool Yoklama { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime DuzenlemeTarihi { get; set; }
    }
}
