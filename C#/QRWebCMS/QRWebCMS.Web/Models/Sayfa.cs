using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class Sayfa
    {
        [Key, DisplayName("Sayfa ID")]
        public int SayfaID{ get; set; }

        [DisplayName("Sayfa Liste ID")]
        public int SayfaListeID{ get; set; }

        [DisplayName("Başlık"), MaxLength(25)]
        public string Baslik { get; set; }

        [DisplayName("İkon"), MaxLength(25)]
        public string Ikon { get; set; }

        [DisplayName("Ek Alan-1")]
        public string EkAlan1{ get; set; }

        [DisplayName("Ek Alan-2")]
        public string EkAlan2 { get; set; }

        public bool Etkin{ get; set; }
    }
}