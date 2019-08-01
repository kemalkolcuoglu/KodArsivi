using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Giris : Form
    {
        string host;
        string port;
        SqlConnection con;
        public Giris()
        {
            port = "8080";
            con = Veriişlemleri.BaglantiSinifi.Con;
            InitializeComponent();
            // Yerel Sunucuya Bağlan
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt_host.Text = address.ToString();
					//host = address.ToString();
					host = "192.168.0.16";
				}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client cln = new Client();
            if (host.Equals(txt_host.Text) && port.Equals(txt_port.Text))
            {
				MainClient mc = new MainClient();
				mc.Connect("192.168.0.16", 8080);
				if (mc.CheckState())
				{
					MessageBox.Show("Bağlantı Sağlandı!");
					groupBox2.Enabled = true;
				}
				else
				    MessageBox.Show("Bağlantı Sağlanamadı! Server Kapalı!");
			}
			else
				MessageBox.Show("Bağlantı Sağlanamadı!");
		}

        private void bt_giris_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            if (Veriişlemleri.GirisYap(txt_kull.Text, txt_pass.Text))
            {
                this.Visible = false;
                cf.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!\nLütfen Tekrar Deneyiniz.");
        }

 
    }
}
