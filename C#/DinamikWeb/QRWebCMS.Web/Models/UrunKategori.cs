using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class UrunKategori
    {
        public int UrunKategoriID { get; set; }

        public int SayfaID { get; set; }

        [Required(), DisplayName("Başlık")]
        public string Baslik { get; set; }

        public bool Etkin { get; set; }

        public virtual int UrunID { get; set; }
        public virtual string UrunBaslik { get; set; }
        public virtual string UrunDetay { get; set; }
        public virtual string UrunGorsel { get; set; }
        public virtual string UrunUcret { get; set; }
        public virtual string UrunEkAlan1 { get; set; }
        public virtual string UrunEkAlan2 { get; set; }
        public virtual bool UrunEtkin { get; set; }
        public virtual bool UrunVitrin { get; set; }
    }
}