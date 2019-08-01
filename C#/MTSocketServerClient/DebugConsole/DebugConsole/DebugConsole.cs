using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DebugConsole.Forms
{
    internal partial class DebugConsole : Form
    {
        public DebugConsole()
        {
            InitializeComponent();
            btn_Ex.Text = "Kapat";
            btn_Ok.Text = "Tamam";
        }
        private int Debug_ListItemCount = 1;

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Ex_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
        private void DebugConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void DebugConsole_Load(object sender, EventArgs e)
        {

        }

        delegate void SetCallback(string Data, string Type, string Direction);

        public void WriteConsole(string Data, string Type, string Direction)
        {
            try
            {
                if (this.Debug_List.InvokeRequired)
                {
                    SetCallback cb = new SetCallback(WriteConsole);
                    this.Invoke(
                        cb,
                        new object[] { Data, Type, Direction });
                }
                else
                {
                    ListViewItem li = new ListViewItem(Debug_ListItemCount.ToString());
                    Debug_ListItemCount++;
                    li.SubItems.Add(Type);
                    li.SubItems.Add(Data);
                    li.SubItems.Add(Direction);
                    li.SubItems.Add(DateTime.Now.ToString());
                    Debug_List.Items.Add(li);
                }
            }
            catch (Exception)
            { }
        }
    }
}
