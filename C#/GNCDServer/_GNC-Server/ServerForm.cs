using MTSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _GNC_Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Girilen.Text == "")
            {
                MessageBox.Show("Önce Giriş Yapmalısım!");
                return;
            }
            MyMainServer.StartServer(8081, System.Net.IPAddress.Any);
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Girilen.Text += txt_Kull.Text;
        }
    }
}
