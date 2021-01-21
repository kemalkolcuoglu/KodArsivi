using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models.EkModel
{
    public class SayfaListeMV
    {
        public Sayfa Sayfa { get; set; }
        public List<SayfaListe> SayfaListe { get; set; }
        public List<Icerik> Icerikler { get; set; }
        public List<GaleriKategori> Galeriler { get; set; }
        public List<SlideKategori> Slidelar { get; set; }
        public List<UrunKategori> Urunler { get; set; }
    }
}