using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        public Form1()
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = OLEDB; Data Source = localhost; Database = kutuphane; Integrated Security = SSPI";
            InitializeComponent();
        }
        public void DataAdapterUse()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From kutup", con);
            DataTable dt = new DataTable("Tablo");
            da.Fill(dt);
        }
        public void CommandUseForOneQuery(string command)
        {
            OleDbCommand com = new OleDbCommand(command, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void CommandUseForRead(string command)
        {
            OleDbCommand com = new OleDbCommand(command, con);
            con.Open();
            OleDbDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            con.Close();
            while (dr.Read())
                Console.WriteLine(dr[0].ToString());
        }

        
    }
}
