using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Il
    {
        [Key, DisplayName("İl Kodu")]
        public int IlKodu { get; set; }

        [DisplayName("İl Adı")]
        public string IlAdi{ get; set; }
    }
}
