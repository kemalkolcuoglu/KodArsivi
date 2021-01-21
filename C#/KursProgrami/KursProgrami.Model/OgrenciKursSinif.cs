namespace KursProgrami.Model
{
    public class OgrenciKursSinif
    {
        public int OgrenciKursSinifID { get; set; }

        public int OgrenciID { get; set; }

        public int KursID { get; set; }

        public int SinifID { get; set; }

        /*--------------- VIEW'DAN GELEN NİTELİKLER (vsinifogrenci) ------------------*/

        public string SinifAdi { get; set; }

        public string OgrenciAdi { get; set; }

        public string OgrenciSoyadi { get; set; }

        public int EgitmenID { get; set; }

        public string EgitmenAdi { get; set; }

        public string EgitmenSoyadi { get; set; }

        /*--------------- VIEW'DAN GELEN NİTELİKLER (vogrenci) ------------------*/
    }
}
