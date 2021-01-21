using IcerikYonetimSistemi.VarlikKatmani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.IslemKatmani
{
	public class Test
	{
		public Test()
		{
			VeriErisimKatmani.DatabaseContext db = new VeriErisimKatmani.DatabaseContext();
			db.Sayfalar.ToList();
		}
	}
}
