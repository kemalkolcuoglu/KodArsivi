using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class Icerik
    {
        [Key, DisplayName("İcerik ID")]
        public int IcerikID { get; set; }

        [DisplayName("Sayfa ID")]
        public int SayfaID { get; set; }

        [DisplayName("Başlık"), MaxLength(100)]
        public string Baslik{ get; set; }

        public string Detay{ get; set; }

        [DisplayName("Görsel")]
        public string Gorsel{ get; set; }

        [DisplayName("Ek Alan-1"), MaxLength(255)]
        public string EkAlan1{ get; set; }

        [DisplayName("Ek Alan-2")]
        public string EkAlan2{ get; set; }

        public bool Etkin{ get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime DuzenlemeTarihi { get; set; }

        public string Ekleyen { get; set; }

        [DisplayName("Düzenleyen")]
        public string Duzenleyen { get; set; }
    }
}