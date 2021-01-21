using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class SayfaListe
    {
        public int SayfaListeID{ get; set; }

        public int SayfaID{ get; set; }

        public int NitelikID{ get; set; }

        public string NitelikTablosu { get; set; }

        public int GosterimSirasi{ get; set; }
    }
}