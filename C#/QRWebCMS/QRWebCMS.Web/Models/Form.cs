using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class Form
    {
        [Key]
        public int FormID { get; set; }

        [DisplayName("Ad Soyad"), MaxLength(50)]
        public string AdSoyad { get; set; }

        [DisplayName("E-Posta"), MaxLength(40)]
        public string EPosta { get; set; }

        [DisplayName("Konu"), MaxLength(20)]
        public string Konu { get; set; }

        [DisplayName("Mesajınız"), MaxLength(500)]
        public string MesajIcerigi { get; set; }

        public DateTime GonderimTarihi { get; set; }
    }
}