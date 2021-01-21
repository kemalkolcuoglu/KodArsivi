using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class GenelAyarlar
    {
        public int GenelAyarlarID { get; set; }

        [DisplayName("Site Logosu"), MaxLength(50)]
        public string Logo { get; set; }

        [DisplayName("Site Adı"), MaxLength(50)]
        public string SiteAdi { get; set; }

        [DisplayName("Şirket Adı"), MaxLength(50)]
        public string SirketAdi { get; set; }

        public bool Etkin { get; set; }

        [DisplayName("E-Posta"), MaxLength(50)]
        public string EPosta { get; set; }

        [MaxLength(25)]
        public string Telefon { get; set; }

        [MaxLength(100)]
        public string Adres { get; set; }

        [DisplayName("Google Harita URL")]
        public string HaritaUrl { get; set; }

        [DisplayName("Ek Alan-1")]
        public string EkAlan1 { get; set; }

        [DisplayName("Ek Alan-2")]
        public string EkAlan2 { get; set; }

        [DisplayName("Anasayfa Modal")]
        public string AnasayfaModal{ get; set; }
    }
}