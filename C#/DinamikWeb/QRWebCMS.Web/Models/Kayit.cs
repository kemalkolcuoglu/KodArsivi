using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QRWebCMS.Web.Models
{
    public class Kayit
    {
        public int KayitID { get; set; }

        [Required, MaxLength(11), DisplayName("T.C. Kimlik No.")]
        public string TCKNO { get; set; }

        public string Cinsiyet { get; set; }

        [Required, MaxLength(25)]
        public string Ad { get; set; }

        [Required, MaxLength(25)]
        public string Soyad { get; set; }

        [MaxLength(25), DisplayName("Kayıtlı/Mezun Olduğu Okul")]
        public string Okul { get; set; }

        [MaxLength(25), DisplayName("Kayıtlı/Mezun Olduğu Okuldaki Sınıfı")]
        public string Sinif { get; set; }

        [MaxLength(25), DisplayName("Nüfusa Kayıtlı Olduğu İl")]
        public string NufusIl { get; set; }

        [MaxLength(100), DisplayName("Aile İkamet Adresi")]
        public string AileIkamet { get; set; }

        [MaxLength(15), DisplayName("Doğum Yeri")]
        public string DogumYeri { get; set; }

        [MaxLength(15), DisplayName("Doğum Yılı")]
        public int DogumYili { get; set; }

        [MaxLength(5), DisplayName("Kan Grubu")]
        public string KanGrubu { get; set; }

        [DisplayName("Bizi Nereden Duydunuz?")]
        public int DuyuruYeri { get; set; }

        [DisplayName("Kayıt Olunacak Kurs")]
        public int Kurs { get; set; }

        [DisplayName("Seçenekler")]
        public int Secenekler { get; set; }

        [MaxLength(25), DisplayName("Anne Adı")]
        public string AnneAdi { get; set; }

        [MaxLength(25), DisplayName("Baba Adı")]
        public string BabaAdi { get; set; }

        [MaxLength(15)]
        public string Telefon { get; set; }

        [MaxLength(15), DisplayName("Cep Telefonu")]
        public string CepTelefon { get; set; }

        [MaxLength(15), DisplayName("Yakının Telefonu")]
        public string YakinTelefon { get; set; }

        [MaxLength(75), DisplayName("E-Posta Adresi")]
        public string EPosta { get; set; }

        public DateTime KayitGonderimTarihi { get; set; }
    }
}