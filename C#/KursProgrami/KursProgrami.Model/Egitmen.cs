using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Egitmen
    {
        [Key]
        public int EgitmenID { get; set; }

        [DisplayName("Kurs")]
        public int KursID { get; set; }

        [Required, DisplayName("T.C. Kimlik No."), MaxLength(11)]
        public string TCKNO { get; set; }

        [Required, DisplayName("Ad"), MaxLength(25)]
        public string Ad { get; set; }

        [Required, DisplayName("Soyad"), MaxLength(25)]
        public string Soyad { get; set; }

        [MaxLength(15)]
        public string Telefon { get; set; }

        [DisplayName("Özel Kod"), MaxLength(255)]
        public string OzelKod { get; set; }

        [DisplayName("Açıklama"), MaxLength(255)]
        public string Aciklama { get; set; }

        public bool Etkin { get; set; }

        [DisplayName("Özel Kod-1"), MaxLength(20)]
        public string OzelKod1 { get; set; }

        [DisplayName("Özel Kod-2"), MaxLength(20)]
        public string OzelKod2 { get; set; }

        [DisplayName("Özel Kod-3"), MaxLength(20)]
        public string OzelKod3 { get; set; }

        [DisplayName("Özel Kod-4"), MaxLength(20)]
        public string OzelKod4 { get; set; }
    }
}
