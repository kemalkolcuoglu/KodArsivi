using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.VeriErisimKatmani
{
	public static class RepositorySingleton
	{
		private static DatabaseContext db;
		private static object obj = new object();

		public static DatabaseContext DbContextOlustur()
		{
			lock (obj)
			{
				if (db == null)
					db = new DatabaseContext();

				return db;
			}
		}
	}
}
