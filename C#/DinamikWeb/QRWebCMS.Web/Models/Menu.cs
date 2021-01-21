using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QRWebCMS.Web.Models
{
    public class Menu
    {
        [Key, DisplayName("Menü ID")]
        public int MenuID { get; set; }

        [DisplayName("Başlık"), MaxLength(25)]
        public string Baslik { get; set; }

        [DisplayName("Sayfa Gösterimi")]
        public bool Sayfa { get; set; }

        [DisplayName("Görüntüleme Sırası")]
        public int GoruntulemeSirasi { get; set; }

        public bool Dropdown{ get; set; }

        [MaxLength(100)]
        public string Link { get; set; }

        [DisplayName("Öğe İkonu")]
        public string Ikon { get; set; }

        public bool Etkin { get; set; }
    }
}