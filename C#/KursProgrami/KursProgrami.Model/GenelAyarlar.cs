using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class GenelAyarlar
    {
        [Key]
        public int GenelAyarlarID { get; set; }

        public int KursID { get; set; }
        
        [DisplayName("SMS Telefon No."), MaxLength(15)]
        public string SMSTelefon { get; set; }

        [DisplayName("SMS Şifre"), MaxLength(25)]
        public string SMSSifre { get; set; }

        [DisplayName("SMS Mesaj Başlık"), MaxLength(25)]
        public string SMSBaslik { get; set; }

        [DisplayName("SMS Gönderimi Etkin")]
        public bool SMSGonderimEtkin { get; set; }

        [DisplayName("E-Posta Sunucusu"), MaxLength(100)]
        public string EPostaSunucusu { get; set; }

        [DisplayName("E-Posta Port"), MaxLength(8)]
        public string EPostaPort { get; set; }

        [DisplayName("E-Posta Adresi"), MaxLength(255)]
        public string EPostaAdresi { get; set; }

        [DisplayName("E-Posta Şifresi"), MaxLength(25)]
        public string EPostaSifresi { get; set; }
    }
}
