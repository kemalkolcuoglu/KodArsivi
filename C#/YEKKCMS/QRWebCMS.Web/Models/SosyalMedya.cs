using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class SosyalMedya
    {
        public int SosyalMedyaID { get; set; }

        public string Baslik { get; set; }

        public string Ikon{ get; set; }

        public string Link{ get; set; }
    }
}