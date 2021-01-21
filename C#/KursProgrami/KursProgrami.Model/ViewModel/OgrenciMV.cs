using System.Web;

namespace KursProgrami.Model.ViewModel
{
    public class OgrenciMV
    {
        public Ogrenci Ogrenci { get; set; }

        public OgrenciIletisim OgrenciIletisim { get; set; }

        public int KursID { get; set; }

        public HttpPostedFileBase OgrenciFoto { get; set; }
    }
}
