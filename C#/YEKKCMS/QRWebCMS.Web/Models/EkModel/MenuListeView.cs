namespace QRWebCMS.Web.Models.EkModel
{
    public class MenuListeView
    {
        public virtual int MenuID { get; set; }
        public virtual string MenuBaslik { get; set; }
        public virtual int MenuGoruntulemeSirasi { get; set; }
        public virtual bool MenuSayfaGoruntuleme { get; set; }
        public virtual bool MenuDropdown { get; set; }
        public virtual string MenuLink { get; set; }
        public virtual bool MenuEtkin { get; set; }
        public virtual int MenuSayfaID { get; set; }
        public virtual int SayfaID { get; set; }
        public virtual int SayfaListeID { get; set; }
        public virtual string SayfaBaslik { get; set; }
        public virtual string SayfaIkon { get; set; }
        public virtual bool SayfaEtkin { get; set; }
    }
}
