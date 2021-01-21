using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    // Şimdilik kullanılmayacak

    public class OgrenciTipi
    {
        [Key]
        public int OgrenciTipiID { get; set; }

        public int KursID{ get; set; }

        [DisplayName("Öğrenci")]
        public int OgrenciID { get; set; }

        [MaxLength(50)]
        public string Durum { get; set; }

        [DisplayName("Açıklama"), MaxLength(255)]
        public string Aciklama { get; set; }
    }
}
