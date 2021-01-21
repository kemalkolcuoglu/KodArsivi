using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class GaleriKategori
    {
        [Key]
        public int GaleriKategoriID{ get; set; }

        [Required(), DisplayName("Başlık"), MaxLength(25)]
        public string Baslik{ get; set; }

        public int SayfaID { get; set; }

        public bool Etkin{ get; set; }

        public virtual int GaleriID{ get; set; }
        public virtual string GaleriBaslik { get; set; }
        public virtual string GaleriGorsel { get; set; }
        public virtual string GaleriDetay { get; set; }
    }
}