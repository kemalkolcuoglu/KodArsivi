using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }

        public int UrunKategoriID{ get; set; }

        [DisplayName("Başlık"), MaxLength(25)]
        public string Baslik { get; set; }

        public string Detay { get; set; }

        [DisplayName("Görsel"), MaxLength(50)]
        public string Gorsel { get; set; }

        [DisplayName("Ücret"), MaxLength(15)]
        public string Ucret{ get; set; }

        [DisplayName("Ek Alan-1"), MaxLength(255)]
        public string EkAlan1 { get; set; }

        [DisplayName("Ek Alan-2"), MaxLength(255)]
        public string EkAlan2 { get; set; }

        public bool Vitrin{ get; set; }

        public bool Etkin { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime DuzenlemeTarihi { get; set; }

        public string Ekleyen { get; set; }

        [DisplayName("Düzenleyen")]
        public string Duzenleyen { get; set; }
    }
}