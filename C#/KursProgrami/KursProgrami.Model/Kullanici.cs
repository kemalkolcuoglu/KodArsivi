using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

        public int KurumID { get; set; }

        public int YetkiID { get; set; }

        public string Tur { get; set; }

        public int NitelikID { get; set; }

        [Required, DisplayName("T.C. Kimlik No."), MaxLength(11)]
        public string TCKNO { get; set; }

        [Required, DisplayName("Şifre"), MaxLength(15)]
        public string Sifre { get; set; }

        public bool Etkin { get; set; }

        /* Anlık Oturum İçin Oluşturulan Property'ler */

        public virtual int SinifID { get; set; }

        public virtual int DonemID { get; set; }

        public virtual string Ad { get; set; }

        public virtual string Soyad { get; set; }
    }
}
