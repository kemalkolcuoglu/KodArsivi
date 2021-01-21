using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProgrami.Model
{
    public class OgrenciNot
    {
        public int OgrenciNotID{ get; set; }

        public int KursID{ get; set; }

        public int DonemID{ get; set; }

        public int OgrenciID{ get; set; }

        public int ProgramID{ get; set; }

        public DateTime Tarih{ get; set; }

        public string NotDurumu{ get; set; }
    }
}
