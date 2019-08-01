using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Client
{
   public class Veriişlemleri
    {
        
		private static SqlConnection con = new SqlConnection("Data Source=192.168.0.16,1433;Network Library = DBMSSOCN; Initial Catalog = vt1; User ID = sa; Password=123456");

		public static DataTable Filtre(string filtre, string aranan)
        {
            string query = "Select * From Bilgiler Where " + filtre + " Like @aranan;";
            SqlDataAdapter da = new SqlDataAdapter(query, BaglantiSinifi.Con);
            da.SelectCommand.Parameters.Add("@aranan", SqlDbType.VarChar).Value = "%" + aranan + "%";
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dt.TableName = "Bilgiler";
                dt.Columns["Ad_Soyad"].ColumnName = "Ad Soyad";
                dt.Columns["Telefon"].ColumnName = "Telefon Numarası";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            return dt;
        }
        public static bool GirisYap(string kull, string pass)
        {
            string[] kayit = new string[2];
            SqlCommand cmd = new SqlCommand("Select * From Kullanici Where KullaniciAdi = '" + kull + "' AND Sifre = '" + pass + "'", BaglantiSinifi.Con);
            BaglantiSinifi.Con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString().Equals(kull) && dr[2].ToString().Equals(pass))
                {
                    BaglantiSinifi.Con.Close();
                    return true;
                }
            }
            BaglantiSinifi.Con.Close();
            return false;
        }

        public static DataTable TabloDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bilgiler", BaglantiSinifi.Con);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "Bilgiler";
                dt.Columns["Ad_Soyad"].ColumnName = "Ad Soyad";
                dt.Columns["Telefon"].ColumnName = "Telefon Numarası";
                return dt;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return null;
            }
        }
        public static string[] BilgileriAl(string aranan)
        {   // Bu method Veri Düzenleme işlemlerinde Formdaki bileşenlere yerleşecek verileri getirir 
            SqlCommand cmd;
            string[] bilgiler = new string[3];
            cmd = new SqlCommand("Select * From Bilgiler Where ID = " + aranan, BaglantiSinifi.Con);
            try
            {
                BaglantiSinifi.Con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < 3; i++)
                        bilgiler[i] = dr[i].ToString();
                }
            }
            catch (Exception exp)
            { Console.WriteLine(exp.Message); }
            finally
            {
                BaglantiSinifi.Con.Close();
            }
            return bilgiler;
        }
        public static class BaglantiSinifi
        {
            
            public static SqlConnection Con => con;
        }
        public static bool KisiEkle(string Kisi,string Telefon)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Bilgiler Values(@s1,@s2)", BaglantiSinifi.Con);
            cmd.Parameters.AddWithValue("@s1",Telefon);
            cmd.Parameters.AddWithValue("@s2", Kisi);
            return Sorgu(cmd);
        }
        public static bool Sorgu(SqlCommand cmd)
        {
            try
            {
                if (BaglantiSinifi.Con.State != ConnectionState.Open)
                    BaglantiSinifi.Con.Open();
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }
			finally
			{
				if(BaglantiSinifi.Con.State.Equals(ConnectionState.Open))
					BaglantiSinifi.Con.Close();
			}
        }
        public static bool KisiDuzenle(string Kisi, string Telefon, string ID)
        {
            SqlCommand cmd = new SqlCommand("Update Bilgiler Set Telefon = @s1, Ad_Soyad = @s2 Where ID = @s3", BaglantiSinifi.Con);
            cmd.Parameters.AddWithValue("@s1", Telefon);
            cmd.Parameters.AddWithValue("@s2", Kisi);
			cmd.Parameters.AddWithValue("@s3", ID);
			return Sorgu(cmd);
        }
        public static bool VeriSil(string silinecek)
        {
            string sorgu = "Delete From Bilgiler Where ID = " + silinecek;
            SqlCommand cmd = new SqlCommand(sorgu, BaglantiSinifi.Con);
            return Sorgu(cmd);
        }
    }
}
