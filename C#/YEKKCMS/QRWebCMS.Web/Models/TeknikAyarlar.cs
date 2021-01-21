using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QRWebCMS.Web.Models
{
    public class TeknikAyarlar
    {
        public int TeknikAyarlarID { get; set; }

        [DisplayName("E-Posta Sunucusu"), MaxLength(40)]
        public string EPostaSunucusu { get; set; }

        [DisplayName("E-Posta Kullanıcı Adı"), MaxLength(25)]
        public string EPostaAdresi { get; set; }

        [DisplayName("E-Posta Şifresi"), MaxLength(25)]
        public string EPostaSifresi { get; set; }

        [DisplayName("E-Posta Sunucu Portu"), MaxLength(8)]
        public string EPostaPort { get; set; }

        [DisplayName("SMS Sunucusu"), MaxLength(40)]
        public string SMSSunucusu { get; set; }

        [DisplayName("SMS Telefon Numarası"), MaxLength(15)]
        public string SMSTelefonNo { get; set; }

        [DisplayName("SMS Şifresi"), MaxLength(25)]
        public string SMSSifresi { get; set; }

        [DisplayName("SMS Mesaj Başlığı"), MaxLength(25)]
        public string SMSMesajBasligi{ get; set; }
    }
}