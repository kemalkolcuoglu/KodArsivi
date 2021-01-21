using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Kurs
    {
        [Key]
        public int KursID { get; set; }

        [Required, DisplayName("Kurs Adı"), MaxLength(100)]
        public string KursAdi { get; set; }

        [MaxLength(100)]
        public string Yetkili { get; set; }

        [MaxLength(15)]
        public string Telefon { get; set; }

        [MaxLength(15)]
        public string Fax { get; set; }

        [DisplayName("İl")]
        public int Il { get; set; }

        [DisplayName("İlçe")]
        public int Ilce { get; set; }

        [MaxLength(255)]
        public string Adres { get; set; }

        [DisplayName("Web Sitesi"), MaxLength(255)]
        public string WebSitesi { get; set; }

        public string Logo { get; set; }

        public string Guid { get; set; }

        [DefaultValue(false)]
        public bool Etkin { get; set; }
    }
}
