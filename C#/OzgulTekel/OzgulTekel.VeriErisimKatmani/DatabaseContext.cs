using OzgulTekel.VarlikKatmani;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgulTekel.VeriErisimKatmani
{
	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public class DatabaseContext : DbContext
	{
		public DbSet<Kullanici> Kullanici { get; set; }
		public DbSet<Satis> Satis { get; set; }
		public DbSet<Urun> Urun { get; set; }
		
		public DatabaseContext()
		{
			Database.SetInitializer(new VeritabaniOlusturma());
		}
	}
}
