using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Ilce
    {
        [Key, DisplayName("İlçe Kodu")]
        public int IlceKodu { get; set; }

        [DisplayName("İl Kodu")]
        public int IlKodu { get; set; }

        [DisplayName("İlçe Adı")]
        public string IlceAdi { get; set; }
    }
}
