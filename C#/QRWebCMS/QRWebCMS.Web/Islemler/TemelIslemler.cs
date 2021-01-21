using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QRWebCMS.Web.Islemler
{
    public class TemelIslemler<T> where T : class
    {
        private string tabloAdi;
        protected string TabloAdi { get { return tabloAdi; } set { tabloAdi = value; } }
        public TemelIslemler(string tabloAdi)
        {
            this.tabloAdi = tabloAdi;
        }

        protected MySqlParameter[] ParametreOlustur(T nesne)
        {
            MySqlParameter parameter;
            List<MySqlParameter> param = new List<MySqlParameter>();
            foreach (var prop in nesne.GetType().GetProperties())
            {
                if (prop.GetMethod.IsVirtual)
                    continue;
                parameter = new MySqlParameter(prop.Name, prop.GetValue(nesne, null));
                if (parameter.Value != null && parameter.Value.GetType() == typeof(string))
                    parameter.DbType = DbType.String;

                param.Add(parameter);
            }
            return param.ToArray();
        }

        protected string ParametreBildirisiOlustur(T nesne)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in nesne.GetType().GetProperties())
            {
                if (prop.GetMethod.IsVirtual)
                    continue;
                sb.Append("@" + prop.Name + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        protected string ParametreBildirisiSutunlar(T nesne)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in nesne.GetType().GetProperties())
            {
                if (prop.GetMethod.IsVirtual)
                    continue;
                sb.Append(prop.Name + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        protected string ParametreBildirisiDuzenle(T nesne)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in nesne.GetType().GetProperties())
            {
                if (prop.GetMethod.IsVirtual)
                    continue;
                sb.Append(prop.Name + " = @" + prop.Name + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        protected List<T> ListeyeCevir(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }

        public List<T> VeriGetirSQL(string sql)
        {
            DataTable dataTable = VeriIslemleri.VeriGetir(sql);
            List<T> liste = ListeyeCevir(dataTable);
            return liste;
        }

        public List<T> VeriGetir(string sart)
        {
            DataTable dataTable = VeriIslemleri.VeriGetir(tabloAdi, sart);
            List<T> liste = ListeyeCevir(dataTable);
            return liste;
        }

        public List<T> VeriGetir(string sart, string istenen)
        {
            DataTable dataTable = VeriIslemleri.VeriGetir(tabloAdi, sart, istenen);
            List<T> liste = ListeyeCevir(dataTable);
            return liste;
        }

        public DataSet VeriGetirSQLDataSet(string sql)
        {
            DataTable dataTable = VeriIslemleri.VeriGetir(sql);
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public DataSet VeriGetirDataSet(string sart)
        {
            DataTable dataTable = VeriIslemleri.VeriGetir(tabloAdi, sart);
            DataSet dataSet = new DataSet(tabloAdi);
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public DataSet VeriGetirDataSet(string sart, string istenen)
        {
            DataTable dataTable = VeriIslemleri.VeriGetir(tabloAdi, sart, istenen);
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public int MaxDeger(string istenilen)
        {
            return VeriIslemleri.MaxDeger(tabloAdi, istenilen);
        }

        public int MaxDeger(string sart, string istenilen)
        {
            return VeriIslemleri.MaxDeger(tabloAdi, sart, istenilen);
        }

        public int VeriSayisi()
        {
            return VeriIslemleri.VeriSayisi(tabloAdi);
        }

        public int VeriSayisi(string sart)
        {
            return VeriIslemleri.VeriSayisi(tabloAdi, sart);
        }

        public int VeriSayisi(string sart, string istenen)
        {
            return VeriIslemleri.VeriSayisi(tabloAdi, sart, istenen);
        }

        public T Bul(string sart)
        {
            List<T> liste = VeriGetir(sart);
            if (liste != null && liste.Count > 0)
                return liste[0];
            return null;
        }

        public int Ekle(T nesne)
        {
            MySqlParameter[] param = ParametreOlustur(nesne);
            string paramBildiri = ParametreBildirisiOlustur(nesne);
            string sutunlar = ParametreBildirisiSutunlar(nesne);
            int sonuc = VeriIslemleri.VeriEkle(tabloAdi, sutunlar, paramBildiri, param);
            return sonuc;
        }

        public int Guncelle(string sart, T nesne)
        {
            MySqlParameter[] param = ParametreOlustur(nesne);
            string paramBildiri = ParametreBildirisiDuzenle(nesne);
            int sonuc = VeriIslemleri.VeriGuncelle(tabloAdi, paramBildiri, sart, param);
            return sonuc;
        }

        public int Guncelle(string sart, string duzenleme, object deger, Type type)
        {
            MySqlParameter param = new MySqlParameter(duzenleme, Convert.ChangeType(deger, type));
            int sonuc = VeriIslemleri.VeriGuncelle(tabloAdi, duzenleme + " = @" + duzenleme, sart, param);
            return sonuc;
        }

        public int Sil(string sart)
        {
            int sonuc = VeriIslemleri.VeriSil(tabloAdi, sart);
            return sonuc;
        }

        public List<T> ProsedureCagir(string prosedureAdi, string parametreBildirisi, MySqlParameter[] parametreler)
        {
            DataTable dataTable = VeriIslemleri.ProsedureCagir(prosedureAdi, parametreBildirisi, parametreler);

            return ListeyeCevir(dataTable);
        }

        public DataSet ProsedureCagirDataSet(string prosedureAdi, string parametreBildirisi, MySqlParameter[] parametreler)
        {
            DataTable dataTable = VeriIslemleri.ProsedureCagir(prosedureAdi, parametreBildirisi, parametreler);
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }
    }
}