using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace QRWebCMS.Web.Islemler
{
    public class VeriIslemleri
    {
        private static string con = ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString;
        private static MySqlConnection mySqlCon = new MySqlConnection(con);


        /// <summary>
        ///     İçerisine aldığı <paramref name="cmd" /> nesnesini ExecuteNonQuery() metodu ile çalıştırır.
        /// </summary>
        /// <param name="cmd">ADO.NET XXXCommand nesnesi</param>
        /// <returns>Veritabanında etkileşen satır sayısını döndürür</returns>
        private static int CommandCalistir(MySqlCommand cmd)
        {
            int sonuc = 0;
            try
            {
                if (mySqlCon.State != ConnectionState.Open)
                    mySqlCon.Open();

                sonuc = cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }
            return sonuc;
        }


        /// <summary>
        ///     İçerisine aldığı <paramref name="cmd" /> nesnesini ExecuteScalar() metodu ile çalıştırır.
        /// </summary>
        /// <param name="cmd">ADO.NET XXXCommand nesnesi</param>
        /// <returns>Veritabanında etkileşen satır sayısını döndürür</returns>
        private static int CommandCalistirScalar(MySqlCommand cmd)
        {
            int sonuc = 0;
            try
            {
                if (mySqlCon.State != ConnectionState.Open)
                    mySqlCon.Open();

                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                if (mySqlCon.State == ConnectionState.Open)
                    mySqlCon.Close();
            }
            return sonuc;
        }

        /// <summary>
        ///     İçerisine aldığı <paramref name="sql" /> parametresi ile Select sorguları için kullanılır.
        /// </summary>
        /// <param name="sql">SQL sorgu cümlesi.</param>
        /// <returns>ADO.NET XXXDataAdaptor sınıfı kullanarak Datatable olarak döndürür</returns>
        public static DataTable VeriGetir(string sql)
        {
            DataTable dataSet = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

            da.Fill(dataSet);
            return dataSet;
        }


        /// <summary>
        ///     İçerisine aldığı parametreler ile Select sorguları için kullanılır.
        /// </summary>
        /// <param name="tablo">Etkileşimdeki tablonun adı</param>
        /// <param name="sart">Where ifadesindeki şart/şartlar</param>
        /// <returns>ADO.NET XXXDataAdaptor sınıfı kullanarak Datatable olarak döndürür</returns>
        public static DataTable VeriGetir(string tablo, string sart)
        {
            DataTable dataSet = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From " + tablo + " Where " + sart, con);

            da.Fill(dataSet);
            return dataSet;
        }


        /// <summary>
        ///     İçerisine aldığı parametreler ile Select sorguları için kullanılır.
        /// </summary>
        /// <param name="tablo">Etkileşimdeki tablonun adı</param>
        /// <param name="sart">Where ifadesindeki şart/şartlar</param>
        /// <param name="istenen">Hangi sutun/sutunların getirilmesi isteniyorsa kullanılır</param>
        /// <returns>ADO.NET XXXDataAdaptor sınıfı kullanarak Datatable olarak döndürür</returns>
        public static DataTable VeriGetir(string tablo, string sart, string istenen)
        {
            DataTable dataSet = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select " + istenen + " From " + tablo + " Where " + sart, con);

            da.Fill(dataSet);
            return dataSet;
        }

        public static int MaxDeger(string tablo, string istenilen)
        {
            MySqlCommand cmd = new MySqlCommand("Select Max(" + istenilen + ") From " + tablo, mySqlCon);
            return CommandCalistirScalar(cmd);
        }

        public static int MaxDeger(string tablo, string sart, string istenilen)
        {
            MySqlCommand cmd = new MySqlCommand("Select Max(" + istenilen + ") From " + tablo +  " Where " + sart, mySqlCon);
            return CommandCalistirScalar(cmd);
        }

        public static int VeriSayisi(string tablo)
        {
            MySqlCommand cmd = new MySqlCommand("Select Count(*) From " + tablo, mySqlCon);
            return CommandCalistirScalar(cmd);
        }

        public static int VeriSayisi(string tablo, string sart)
        {
            MySqlCommand cmd = new MySqlCommand("Select Count(*) From " + tablo + " Where " + sart, mySqlCon);
            return CommandCalistirScalar(cmd);
        }

        public static int VeriSayisi(string tablo, string sart, string istenen)
        {
            MySqlCommand cmd = new MySqlCommand("Select Count(" + istenen + ") From " + tablo + " Where " + sart, mySqlCon);
            return CommandCalistirScalar(cmd);
        }

        public static int VeriEkle(string tablo, string sutunlar, string parametreBildirisi, MySqlParameter[] parametreler)
        {
            MySqlCommand cmd = new MySqlCommand("Insert Into " + tablo + "(" + sutunlar + ") Values(" + parametreBildirisi + ")", mySqlCon);
            cmd.Parameters.AddRange(parametreler);
            return CommandCalistir(cmd);
        }

        public static int VeriGuncelle(string tablo, string parametreBildirisi, string sart, MySqlParameter parametre)
        {
            MySqlCommand cmd = new MySqlCommand("Update " + tablo + " Set " + parametreBildirisi + " Where " + sart, mySqlCon);
            cmd.Parameters.Add(parametre);
            return CommandCalistir(cmd);
        }

        public static int VeriGuncelle(string tablo, string parametreBildirisi, string sart, MySqlParameter[] parametreler)
        {
            MySqlCommand cmd = new MySqlCommand("Update " + tablo + " Set " + parametreBildirisi + " Where " + sart, mySqlCon);
            cmd.Parameters.AddRange(parametreler);
            return CommandCalistir(cmd);
        }

        public static int VeriSil(string tablo, string sart)
        {
            MySqlCommand cmd = new MySqlCommand("Delete From " + tablo + " Where " + sart, mySqlCon);
            return CommandCalistir(cmd);
        }

        public static DataTable ProsedureCagir(string prosedureAdi, string parametreBildirisi, MySqlParameter[] parametreler)
        {
            DataTable dataSet = new DataTable();
            MySqlCommand cmd = new MySqlCommand(prosedureAdi, mySqlCon);
            cmd.Parameters.AddRange(parametreler);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dataSet);
            return dataSet;
        }
    }
}