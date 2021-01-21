using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluModulFiyatHesaplama
{
    public partial class Form1 : Form
    {
        private List<Modul> moduller;
        private int egitim;
        private List<Modul> kullanilanmoduller;
        public Form1()
        {
            InitializeComponent();
            this.moduller = this.ModulleriOlustur();
            this.egitim = 2; // 1 - Ağ, 2 - Siber
            this.kullanilanmoduller = new List<Modul>();
        }

        private List<Modul> ModulleriOlustur()
        {
            Modul modul1 = new Modul()
            {
                ID = 1,
                Ad = "Network Eğitimi",
                KursID = 0,
                Ucret = 1960,
                IndirimOrani = 10,
                Aktif = true,
                Indirim = true
            };
            Modul modul2 = new Modul()
            {
                ID = 2,
                Ad = "Windows Server 2019",
                KursID = 0,
                Ucret = 1960,
                IndirimOrani = 20,
                Aktif = true,
                Indirim = true
            };
            Modul modul3 = new Modul()
            {
                ID = 3,
                Ad = "Linux LPIC-1",
                KursID = 0,
                Ucret = 1960,
                IndirimOrani = 30,
                Aktif = true,
                Indirim = true
            };
            Modul modul4 = new Modul()
            {
                ID = 4,
                Ad = "SOC Siber Güvenlik Analist Eğitimi",
                KursID = 2,
                Ucret = 1960,
                IndirimOrani = 40,
                Aktif = false,
                Indirim = true
            };
            Modul modul5 = new Modul()
            {
                ID = 5,
                Ad = "CEHv11 (Beyaz Şapkalı Hacker)",
                KursID = 2,
                Ucret = 1960,
                IndirimOrani = 50,
                Aktif = false,
                Indirim = true
            };
            Modul modul6 = new Modul()
            {
                ID = 4,
                Ad = "Microsoft Azure ve AWS",
                KursID = 1,
                Ucret = 1960,
                IndirimOrani = 40,
                Aktif = false,
                Indirim = true
            };
            Modul modul7 = new Modul()
            {
                ID = 5,
                Ad = "CCNP ENCOR Eğitimi",
                KursID = 1,
                Ucret = 1960,
                IndirimOrani = 50,
                Aktif = false,
                Indirim = true
            };
            Modul modul8 = new Modul()
            {
                ID = 6,
                Ad = "KVKK Eğitimi",
                KursID = 0,
                Ucret = 395,
                IndirimOrani = 50,
                Aktif = true,
                Indirim = true
            };
            Modul modul9 = new Modul()
            {
                ID = 7,
                Ad = "ISO-27001 BGYS",
                KursID = 0,
                Ucret = 395,
                IndirimOrani = 50,
                Aktif = true,
                Indirim = true
            };
            Modul modul10 = new Modul()
            {
                ID = 8,
                Ad = "Kariyer Eğitimi",
                KursID = 0,
                Ucret = 395,
                IndirimOrani = 50,
                Aktif = true,
                Indirim = true
            };
            List<Modul> moduller = new List<Modul>()
            {
                modul1, modul2, modul3, modul4, modul5, modul6, modul7, modul8, modul9, modul10
            };
            return moduller;
        }

        private void rb_siber_CheckedChanged(object sender, EventArgs e)
        {
            this.egitim = 2;
            List<Modul> moduller = this.moduller.FindAll(x => x.KursID == 0 || x.KursID == this.egitim);
            moduller[3].Aktif = true;
            moduller[4].Aktif = true;
            this.kullanilanmoduller = moduller;
            DinamikComponetOlusturma(moduller);
        }

        private void rb_ag_CheckedChanged(object sender, EventArgs e)
        {
            this.egitim = 1;
            List<Modul> moduller = this.moduller.FindAll(x => x.KursID == 0 || x.KursID == this.egitim);
            moduller[3].Aktif = true;
            moduller[4].Aktif = true;
            this.kullanilanmoduller = moduller;
            DinamikComponetOlusturma(moduller);
        }

        private void DinamikComponetOlusturma(List<Modul> moduller)
        {
            gb_moduller.Controls.Clear();
            lb_araToplam.Text = "0,00";
            lb_toplam_fiyat.Text = "0,00";
            int checkboxX = 14;
            int ilkY = 31;
            int textboxX = 215;
            int labelX = 351;
            int nupX = 455;
            int counter = 1;
            decimal fiyat = 0;
            foreach (var item in moduller)
            {
                CheckBox checkBox = new CheckBox()
                {
                    Text = item.Ad,
                    Checked = true,
                    Visible = true,
                    Location = new Point(checkboxX, counter * ilkY),
                    Name = $"cb_aktif_{counter}"
                };
                TextBox textBox = new TextBox()
                {
                    Text = item.Ucret.ToString(),
                    Visible = true,
                    Enabled = false,
                    Location = new Point(textboxX, counter * ilkY),
                    Name = $"tb_ucret_{counter}"
                };
                CheckBox cb_indirim = new CheckBox()
                {
                    Text = "Indirim: ",
                    Visible = true,
                    Enabled = true,
                    Checked = true,
                    Location = new Point(labelX, counter * ilkY),
                    Name = $"cb_indirim_{counter}"
                };
                NumericUpDown NumericUpDown = new NumericUpDown()
                {
                    Value = item.IndirimOrani,
                    Visible = true,
                    Enabled = false,
                    Location = new Point(nupX, counter * ilkY),
                    Size = new Size(60, 20),
                    Name = $"nup_oran_{item.ID}"
                };
                gb_moduller.Controls.Add(checkBox);
                gb_moduller.Controls.Add(textBox);
                gb_moduller.Controls.Add(cb_indirim);
                gb_moduller.Controls.Add(NumericUpDown);

                checkBox.CheckedChanged += new EventHandler(this.CheckboxCheckEventHandler);
                cb_indirim.CheckedChanged += new EventHandler(this.CheckboxIndirimEventHandler);

                counter++;
                fiyat += item.Ucret - ((item.Ucret * item.IndirimOrani) / 100);
            }
            lb_araToplam.Text = fiyat.ToString();
            ToplamFiyatHesapla();
        }
        
        private void FiyatHesapla()
        {
            decimal fiyat = 0;
            foreach (var item in this.kullanilanmoduller)
            {
                if (item.Aktif)
                    if (item.Indirim)
                        fiyat += item.Ucret - ((item.Ucret * item.IndirimOrani) / 100);
                    else
                        fiyat += item.Ucret;
            }
            lb_araToplam.Text = fiyat.ToString();
        }

        private void ToplamFiyatHesapla()
        {
            decimal fiyat = 0;
            decimal indirim = 0;
            decimal kisiSayisi = nud_kisi.Value;
            decimal kisiIndirimi = nud_kisiIndirimi.Value;
            decimal araFiyat = Convert.ToDecimal(lb_araToplam.Text);
            indirim = kisiSayisi * ((araFiyat * kisiIndirimi) / 100);
            fiyat += kisiSayisi * (araFiyat - ((araFiyat * kisiIndirimi) / 100));
            lb_toplamIndirimMiktari.Text = indirim.ToString();
            lb_toplam_fiyat.Text = fiyat.ToString();
        }

        private void CheckboxCheckEventHandler(object sender, System.EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            string c = checkbox.Name.Last().ToString();
            int index = Convert.ToInt32(c) -1;
            kullanilanmoduller[index].Aktif = checkbox.Checked;
            IndirimOraniDuzenle();
            FiyatHesapla();
            ToplamFiyatHesapla();
        }

        private void IndirimOraniDuzenle()
        {
            int oran = 1;
            foreach (var item in this.kullanilanmoduller)
            {
                var a = this.gb_moduller.Controls.Find($"nup_oran_{item.ID}", false)[0];
                if (item.Aktif && item.Indirim)
                {
                    item.IndirimOrani = oran * 10;
                    a.Text = item.IndirimOrani.ToString();
                    if (oran < 5)
                        oran++;
                }
                else
                    a.Text = "0";
            }
            
        }

        private void CheckboxIndirimEventHandler(object sender, System.EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string c = checkBox.Name.Last().ToString();
            int index = Convert.ToInt32(c);
            this.kullanilanmoduller[index - 1].Indirim = checkBox.Checked;
            /*var nup = this.gb_moduller.Controls.Find($"nup_oran_{index}", false).FirstOrDefault();
            if(nup.Text == "0")
            {
                int indirimOrani = this.kullanilanmoduller.Find(x => x.ID == Convert.ToInt32(c)).IndirimOrani;
                nup.Text = checkBox.Checked ? indirimOrani.ToString() : "0";
            }
            else
                nup.Text = checkBox.Checked ? nup.Text : "0";*/
            IndirimOraniDuzenle();
            FiyatHesapla();
            ToplamFiyatHesapla();
        }

        private void nud_kisiIndirimi_ValueChanged(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
        }

        private void nud_kisi_ValueChanged(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
        }
    }
}
