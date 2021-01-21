using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class SlideKategori
    {
        public int SlideKategoriID{ get; set; }

        [Required(), DisplayName("Başlık"), MaxLength(50)]
        public string Baslik{ get; set; }

        [DisplayName("Slayt Tipi")]
        public string Tur { get; set; }

        public int SayfaID { get; set; }

        public bool Etkin { get; set; }

        public virtual int SlideID { get; set; }
        public virtual string SlideBaslik { get; set; }
        public virtual string SlideGorsel { get; set; }
    }
}