using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Sinif
    {
        [Key]
        public int SinifID { get; set; }

        public int KursID { get; set; }

        [DisplayName("Eğitmen")]
        public int EgitmenID { get; set; }

        [DisplayName("Sınıf Adı"), MaxLength(255)]
        public string SinifAdi { get; set; }

        [DisplayName("Açıklama"), MaxLength(255)]
        public string SinifAciklama { get; set; }

        [DisplayName("Kontenjan")]
        public int Konteyjan { get; set; }

        public bool Etkin { get; set; }

        // ---------------------- VIEW'DAN GELEN VERİLER (vsinif) ----------------

        public string EgitmenAd { get; set; }
        public string EgitmenSoyad { get; set; }

        // ---------------------- VIEW'DAN GELEN VERİLER (vsinif) ----------------
    }
}
