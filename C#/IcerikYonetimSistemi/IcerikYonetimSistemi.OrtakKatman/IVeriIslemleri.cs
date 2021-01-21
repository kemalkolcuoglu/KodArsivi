using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcerikYonetimSistemi.OrtakKatman
{
	public interface IVeriIslemleri<T>
	{
		int Kaydet();
		T Bul(Expression<Func<T, bool>> where);
		List<T> VeriListesi();
		List<T> VeriListesi(Expression<Func<T, bool>> where);
		IQueryable<T> Sorgu();
		int Ekle(T obj);
		int Guncelle(T obj);
		int Sil(T obj);
		int VeriSayisi();
	}
}
