using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }

        [DisplayName("Kurs")]
        public int KursID { get; set; }

        public int Durum { get; set; } // Durum enum üzerinden işlem yapılıyor

        [Required, DisplayName("T.C. Kimlik No."), MaxLength(11)]
        public string TCKNO { get; set; }

        [Required, MaxLength(25)]
        public string Ad { get; set; }

        [Required, MaxLength(25)]
        public string Soyad { get; set; }

        public string Cinsiyet { get; set; }

        [DisplayName("Doğum Yeri"), MaxLength(15)]
        public string DogumYeri { get; set; }

        [Required, DisplayName("Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }

        [DisplayName("Anne Adı"), MaxLength(25)]
        public string AnneAdi { get; set; }

        [DisplayName("Baba Adı"), MaxLength(25)]
        public string BabaAdi { get; set; }

        [DisplayName("Anne Mesleği"), MaxLength(255)]
        public string AnneMeslegi { get; set; }

        [DisplayName("Baba Mesleği"), MaxLength(255)]
        public string BabaMeslegi { get; set; }

        [DisplayName("Engel Durumu")]
        public bool EngelDurumu { get; set; }

        [MaxLength(25)]
        public string Engeli { get; set; }

        public bool Etkin { get; set; }

        public string Guid { get; set; }

        public string Fotograf { get; set; }

        public DateTime KayitTarihi { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public string Ekleyen { get; set; }

        [DisplayName("Açıklama"), MaxLength(255)]
        public string Aciklama { get; set; }

        [DisplayName("Özel Kod-1"), MaxLength(20)]
        public string OzelKod1{ get; set; }

        [DisplayName("Özel Kod-2"), MaxLength(20)]
        public string OzelKod2{ get; set; }

        [DisplayName("Özel Kod-3"), MaxLength(20)]
        public string OzelKod3{ get; set; }

        [DisplayName("Özel Kod-4"), MaxLength(20)]
        public string OzelKod4{ get; set; }


        /*--------------- VIEW'DAN GELEN NİTELİKLER (vogrenci) ------------------*/

        public virtual int SinifID { get; set; }
        public virtual string SinifAdi { get; set; }
        public virtual string Telefon1 { get; set; }
        public virtual string Telefon2 { get; set; }
        public virtual string EPosta { get; set; }

        /*--------------- VIEW'DAN GELEN NİTELİKLER (vogrenci) ------------------*/

    }
}
