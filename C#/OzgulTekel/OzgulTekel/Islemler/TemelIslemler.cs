using OzgulTekel.VeriErisimKatmani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OzgulTekel.Islemler
{
	public class TemelIslemler<T> where T : class
	{
		private Repository<T> repo = new Repository<T>();

		public virtual T Bul(Expression<Func<T, bool>> where)
		{
			return repo.Bul(where);
		}

		public virtual int Ekle(T obj)
		{
			return repo.Ekle(obj);
		}

		public List<T> VeriListesi(Expression<Func<T, bool>> where)
		{
			return repo.VeriListesi(where);
		}

		public virtual int Guncelle(T obj)
		{
			return repo.Guncelle(obj);
		}

		public virtual int Kaydet()
		{
			return repo.Kaydet();
		}

		public virtual int Sil(T obj)
		{
			return repo.Sil(obj);
		}

		public virtual List<T> VeriListesi()
		{
			return repo.VeriListesi();
		}

		public virtual int VeriSayisi()
		{
			return repo.VeriSayisi();
		}

		public virtual IQueryable<T> Sorgu()
		{
			return repo.Sorgu();
		}
	}
}
