using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class OgrenciIletisim
    {
        [Key]
        public int OgrenciIletisimID { get; set; }

        public int OgrenciID { get; set; }

        [DisplayName("Telefon-1"), MaxLength(15)]
        public string Telefon1 { get; set; }

        [DisplayName("Telefon-2"), MaxLength(15)]
        public string Telefon2 { get; set; }

        [DisplayName("E-Posta"), MaxLength(100)]
        public string EPosta{ get; set; }

        [DisplayName("İl")]
        public int Il { get; set; }

        [DisplayName("İlçe")]
        public int Ilce { get; set; }

        [MaxLength(255)]
        public string Adres { get; set; }
    }
}
