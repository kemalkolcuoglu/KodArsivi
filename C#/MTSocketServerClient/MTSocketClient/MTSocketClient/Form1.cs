using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTSocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mc.Connect("192.168.0.16", 8000);
            if (mc.CheckState())
            {
                MessageBox.Show("Connected");
            }
        }
        MainClient mc = new MainClient();

        private void btn_Send_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(mc.Send(textBox1.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

    }
}
