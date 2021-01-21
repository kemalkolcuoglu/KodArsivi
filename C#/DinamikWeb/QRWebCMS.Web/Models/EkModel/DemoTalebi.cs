using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QRWebCMS.Web.Models.EkModel
{
    public class DemoTalebi
    {
        [Required, DisplayName("Ad Soyad"), MaxLength(50)]
        public string AdSoyad { get; set; }

        [Required, DisplayName("E-Posta Adresi"), MaxLength(100)]
        public string EPosta { get; set; }

        [Required, MaxLength(15)]
        public string Telefon { get; set; }

        [Required, DisplayName("Bulunduğu İl"), MaxLength(20)]
        public string BulunduguIl { get; set; }

        [Required, DisplayName("Bulunduğu İlçe"), MaxLength(30)]
        public string BulunduguIlce { get; set; }

        [Required, DisplayName("Kurum Adı"), MaxLength(100)]
        public string KurumAdi { get; set; }

        [DisplayName("Talep Edilen Ürün")]
        public string TalepUrun { get; set; }
    }
}