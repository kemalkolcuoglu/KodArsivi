using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.IslemKatmani
{
	public class IslemKatmaniOgesi<T>
	{
		public List<string> Hatalar { get; set; }
		public T Varlik { get; set; }

		public IslemKatmaniOgesi()
		{
			Hatalar = new List<string>();
		}
	}
}
