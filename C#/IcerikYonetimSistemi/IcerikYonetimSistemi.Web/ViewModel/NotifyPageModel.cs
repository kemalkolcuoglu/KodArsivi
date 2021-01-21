using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IcerikYonetimSistemi.Web.ViewModel
{
	public class NotifyPageModel
	{
		public List<string> Liste { get; set; } // Hata ise hatalar vb öğeler

		public string SayfaBasligi { get; set; }

		public string Header { get; set; }

		public string SayfaMetni { get; set; }

		public bool YonlendirmeEtkin { get; set; }

		public string YonlendirmeUri { get; set; }

		public string Ikon { get; set; }

		public string SayfaRengi { get; set; }
	}
}