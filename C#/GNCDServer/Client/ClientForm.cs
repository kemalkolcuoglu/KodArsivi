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
    public partial class ClientForm : Form
    {
        string filtre;
        string id;
        DataTable dt;

        public ClientForm()
        {
            InitializeComponent();
            dt = Veriişlemleri.TabloDoldur();
            dataGridView1.DataSource = dt;
			try
			{
				if (dataGridView1.Rows[0].Cells[0].Value != null)
					id = dataGridView1.Rows[0].Cells[0].Value.ToString();
			}
			catch (Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender == btn_Ekle)
            {
                Ekle_Düzenle ekd = new Ekle_Düzenle();
                ekd.ShowDialog();
            }

            else if (sender == btn_Duzenle)
            {
                string[] bilgiler = Veriişlemleri.BilgileriAl(id);
                Ekle_Düzenle ekd = new Ekle_Düzenle(bilgiler);
                ekd.ShowDialog();
            }

            dt = Veriişlemleri.TabloDoldur();
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            try
            {
                id = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
            catch
            { }
        }

        private void bt_sil_Click(object sender, EventArgs e)
        {
            bool durum = false;
            DialogResult cevap = MessageBox.Show(id + "'li kişi Silinecek. Silmek İstediğinize Emin Misiniz?", "Kişi Silinecek", MessageBoxButtons.OKCancel);
            if (cevap.ToString() == "OK")
                    durum = Veriişlemleri.VeriSil(id);
            if (durum)
            {
                MessageBox.Show("Silme işlemi başarılı!");
                dataGridView1.DataSource = Veriişlemleri.TabloDoldur();
                dataGridView1.Update();
            }
        }

        private void bt_filtrele_Click(object sender, EventArgs e)
        {
            if (!rb_ID.Checked && !rb_AD.Checked && !rb_Tel.Checked || txt_filtre.Text == "")
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
                dataGridView1.DataSource = dt;
            }
            else
                dt = Veriişlemleri.Filtre(filtre, txt_filtre.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            txt_filtre.Clear();
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }
    }
}
