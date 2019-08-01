using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Ekle_Düzenle : Form
    {
        string gonderen;
		string id;
        public Ekle_Düzenle()
        {
            gonderen = "Ekle";
            InitializeComponent();
        }

        public Ekle_Düzenle(string[] kayitlar)
        {
            gonderen = "Düzenle";
            InitializeComponent();
			id = kayitlar[0];
            txt_Tel.Text = kayitlar[1];
            txt_Ad.Text = kayitlar[2];
        }

        public bool GirdiKontrol()
        {
            try
            {
                if (txt_Ad.Text != "" && txt_Tel.Text != "")
                    return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
               
            }
            return false;
        }

        private void bt_onayla_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                if (gonderen == "Ekle")
                {
                    if (Veriişlemleri.KisiEkle(txt_Ad.Text, txt_Tel.Text))
                    {
                        MessageBox.Show("Kişi Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
                else if (gonderen == "Düzenle")
                {
                    if (Veriişlemleri.KisiDuzenle(txt_Ad.Text, txt_Tel.Text, id))
                    {
                        MessageBox.Show("Kişi Düzenleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
        }
    }
}
