using KursProgrami.Model.Enum;
using System.Collections.Generic;
using System.Web.Mvc;
using static KursProgrami.Web.App_Start.Tanimlamalar;

namespace KursProgrami.Web.Models
{
    public static class SelectListOlusturma
    {
        public static SelectList IlListele()
        {
            List<SelectListItem> sli = new List<SelectListItem>();
            SelectListItem secim = new SelectListItem() { Text = "Lütfen İl Seçiniz", Value = "-1" };
            sli.Add(secim);
            foreach (var item in ilIslemleri.VeriGetir("1 = 1"))
            {
                SelectListItem s = new SelectListItem()
                {
                    Text = item.IlAdi,
                    Value = item.IlKodu.ToString()
                };
                sli.Add(s);
            }
            return new SelectList(sli, "Value", "Text");
        }

        public static SelectList IlceListele()
        {
            List<SelectListItem> sli = new List<SelectListItem>();
            SelectListItem secim = new SelectListItem() { Text = "Lütfen İlçe Seçiniz", Value = "-1" };
            sli.Add(secim);
            foreach (var item in ilceIslemleri.VeriGetir("1 = 1"))
            {
                SelectListItem s = new SelectListItem()
                {
                    Text = item.IlceAdi,
                    Value = item.IlceKodu.ToString()
                };
                sli.Add(s);
            }
            return new SelectList(sli, "Value", "Text");
        }

        public static SelectList DurumListele()
        {
            SelectListItem d6 = new SelectListItem() { Text = "Durum Seçiniz", Value = "-1" };
            SelectListItem d1 = new SelectListItem() { Text = Durum.Aktif.ToString(), Value = ((int)Durum.Aktif).ToString() };
            SelectListItem d2 = new SelectListItem() { Text = Durum.Mezun.ToString(), Value = ((int)Durum.Mezun).ToString() };
            SelectListItem d3 = new SelectListItem() { Text = Durum.Terk.ToString(), Value = ((int)Durum.Terk).ToString() };
            SelectListItem d4 = new SelectListItem() { Text = Durum.Ayrildi.ToString(), Value = ((int)Durum.Ayrildi).ToString() };
            SelectListItem d5 = new SelectListItem() { Text = Durum.Dondurdu.ToString(), Value = ((int)Durum.Dondurdu).ToString() };

            return new SelectList(new List<SelectListItem>() { d6, d1, d2, d3, d4, d5 }, "Value", "Text");
        }

        public static SelectList EgitmenListele()
        {
            List<SelectListItem> sli = new List<SelectListItem>();
            SelectListItem secim = new SelectListItem() { Text = "Lütfen Eğitmen Seçiniz", Value = "-1" };
            sli.Add(secim);
            foreach (var item in egitmenIslemleri.VeriGetir("Etkin = 1 And KursID = " + AnlikOturum.Kullanici.KurumID))
            {
                SelectListItem s = new SelectListItem()
                {
                    Text = item.Ad + " " + item.Soyad,
                    Value = item.EgitmenID.ToString()
                };
                sli.Add(s);
            }
            return new SelectList(sli, "Value", "Text");
        }

        public static SelectList OgrenciListele()
        {
            List<SelectListItem> sli = new List<SelectListItem>();
            SelectListItem secim = new SelectListItem() { Text = "Lütfen Öğrenci Seçiniz", Value = "-1" };
            sli.Add(secim);
            foreach (var item in ogrenciIslemleri.VeriGetir("Etkin = 1 And KursID = " + AnlikOturum.Kullanici.KurumID))
            {
                SelectListItem s = new SelectListItem()
                {
                    Text = item.Ad + " " + item.Soyad,
                    Value = item.OgrenciID.ToString()
                };
                sli.Add(s);
            }
            return new SelectList(sli, "Value", "Text");
        }
    }
}