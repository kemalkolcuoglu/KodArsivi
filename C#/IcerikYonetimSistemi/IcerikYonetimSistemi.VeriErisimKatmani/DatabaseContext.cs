using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcerikYonetimSistemi.VarlikKatmani;

namespace IcerikYonetimSistemi.VeriErisimKatmani
{
	[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
	public class DatabaseContext : DbContext
	{
		public DbSet<Formlar> Formlar { get; set; }
		public DbSet<FotografGaleri> FotoGaleri { get; set; }
		public DbSet<Kullanici> Kullanici { get; set; }
		public DbSet<KullaniciYetki> KullaniciYetki { get; set; }
		public DbSet<SayfaAltIcerik> SayfaAltIcerik { get; set; }
		public DbSet<SayfaIcerik> SayfaIcerik { get; set; }
		public DbSet<SayfaIcerikGaleri> SayfaIcerikGaleri { get; set; }
		public DbSet<SayfaIcerikYorum> SayfaIcerikYorum { get; set; }
		public DbSet<Sayfalar> Sayfalar { get; set; }

		public DatabaseContext()
		{
			Database.SetInitializer(new VeritabaniOlusturma());
		}
	}
}
