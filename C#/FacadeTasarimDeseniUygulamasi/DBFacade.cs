using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DBFacade
    {
        public string ConnectionString { get; set; }
        private OleDbConnection con;
        static DBFacade _DB;
        private DBFacade()
        {
            con = new OleDbConnection(ConnectionString);
        }
        public static DBFacade CreateObject()
        {
            if (_DB == null)
                _DB = new DBFacade();
            return _DB;
        }

        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch(Exception)
            {
                Console.WriteLine("Hata!");
            }
        }
        public void Disconnect()
        {
            try
            {
                con.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Hata!");
            }
        }
        public int Exec(string sqlQuery, string[] sqlPrms)
        {
            OleDbCommand com = new OleDbCommand(sqlQuery, con);
            /*
            com.Parameters.Add("@ID", OleDbType.Integer);
            com.Parameters["@ID"].Value = Convert.ToInt32(sqlPrms[0]);
            com.Parameters.Add("@Field", OleDbType.VarChar);
            com.Parameters["@Field"].Value = sqlPrms[1];
            */
            OleDbParameter[] prm = new OleDbParameter[2];
            for(int i=0; i<prm.Length;i++)
            {
                prm[i] = new OleDbParameter();
                prm[i].OleDbType = OleDbType.Integer;
                prm[i].ParameterName = sqlPrms[i*2];
                prm[i].Value = Convert.ToInt32(sqlPrms[i*2+1]);
            }
            Connect();
            int sayi = com.ExecuteNonQuery();
            Disconnect();
            return sayi; 
        }
    }
}
