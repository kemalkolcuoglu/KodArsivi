using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTSocket.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DebugConsole.Debugger.isGUIMode = true;
        }

        private void S_StartStop_Click(object sender, EventArgs e)
        {
            DebugConsole.Debugger.WriteConsole("Server Başlıyor...", "Main Form", "");
            MainServer.StartServer(8000, System.Net.IPAddress.Any);
            S_StartStop.Enabled = false;
        }

        private void S_Debugger_Click(object sender, EventArgs e)
        {
            DebugConsole.Debugger.ShowConsole();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainServer.StopServer();
        }
    }
}
