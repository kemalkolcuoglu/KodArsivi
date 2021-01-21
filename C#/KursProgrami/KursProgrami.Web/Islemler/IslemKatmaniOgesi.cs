using System.Collections.Generic;

namespace KursProgrami.Web.Islemler
{
    public class IslemKatmaniOgesi<T> where T : class
    {
        public List<string> Hatalar { get; set; }
        public List<string> Mesajlar { get; set; }
        public T Varlik { get; set; }

        public IslemKatmaniOgesi()
        {
            Hatalar = new List<string>();
            Mesajlar = new List<string>();
        }
    }
}