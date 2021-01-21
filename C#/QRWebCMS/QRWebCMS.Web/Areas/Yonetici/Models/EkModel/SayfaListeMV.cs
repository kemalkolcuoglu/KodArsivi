using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Areas.Yonetici.Models.EkModel
{
    public class SayfaListeMV
    {
        public List<int> IcerikListesi{ get; set; }
        public List<int> SlideListesi{ get; set; }
        public List<int> GaleriListesi{ get; set; }
        public List<int> UrunListesi{ get; set; }
    }
}