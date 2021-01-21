using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Ders
    {
        [Key]
        public int DersID { get; set; }

        public int KursID { get; set; }

        public int SinifID { get; set; }

        [DisplayName("Ders Adı"), MaxLength(255)]
        public string DersAdi { get; set; }

        [DisplayName("Ders Adı"), MaxLength(255)]
        public string DersAciklamasi { get; set; }

        public bool Etkin{ get; set; }

        // ---------------------- VIEW'DAN GELEN VERİLER (vders) ---------------- \\

        public string SinifAdi{ get; set; }

        // ---------------------- VIEW'DAN GELEN VERİLER (vders) ---------------- \\
    }
}
