using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class Slide
    {
        [Key]
        public int SlideID{ get; set; }

        public int SlideKategoriID{ get; set; }

        [DisplayName("Başlık"), MaxLength(100)]
        public string Baslik{ get; set; }

        [DisplayName("Görsel"), MaxLength(255)]
        public string Gorsel{ get; set; }

        public bool Etkin{ get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime EklemeTarihi{ get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime DuzenlemeTarihi{ get; set; }

        public string Ekleyen{ get; set; }

        [DisplayName("Düzenleyen")]
        public string Duzenleyen{ get; set; }
    }
}