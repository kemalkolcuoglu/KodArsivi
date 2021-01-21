using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRWebCMS.Web.Models
{
    public class Kullanici
    {
        [DisplayName("Kullanıcı ID")]
        public int KullaniciID { get; set; }

        [DisplayName("Kullanıcı Yetki ID")]
        public int KullaniciYetkiID { get; set; }

        [DisplayName("Kullanıcı Adı"), MaxLength(15)]
        public string KullaniciAdi { get; set; }

        [DisplayName("Şifre"), MaxLength(10)]
        public string Sifre { get; set; }

        public bool Etkin { get; set; }

        public string Guid { get; set; }
    }
}