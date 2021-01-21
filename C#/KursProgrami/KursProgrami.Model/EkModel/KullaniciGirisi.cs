using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model.EkModel
{
    public class KullaniciGirisi
    {
        [Required, DisplayName("T.C. Kimlik No."), MaxLength(11)]
        public string TCKNO { get; set; }

        [Required, DisplayName("Şifre"), MaxLength(15)]
        public string Sifre { get; set; }
    }
}
