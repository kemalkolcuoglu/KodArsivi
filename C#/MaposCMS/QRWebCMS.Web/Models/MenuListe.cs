using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class MenuListe
    {
        public int MenuSayfaID{ get; set; }
        public int MenuID{ get; set; }
        public int SayfaID{ get; set; }

        public virtual string MenuBaslik { get; set; }
        public virtual int MenuGoruntulemeSirasi { get; set; }
        public virtual bool MenuSayfaGoruntuleme { get; set; }
        public virtual bool MenuDropdown { get; set; }
        public virtual string MenuIkon { get; set; }
        public virtual string MenuLink { get; set; }
        public virtual bool MenuEtkin { get; set; }
        public virtual int SayfaListeID { get; set; }
        public virtual string SayfaBaslik { get; set; }
        public virtual string SayfaIkon { get; set; }
        public virtual bool SayfaEtkin { get; set; }
    }
}