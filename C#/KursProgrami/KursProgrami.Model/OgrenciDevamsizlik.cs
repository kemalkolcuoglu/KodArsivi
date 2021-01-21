using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProgrami.Model
{
    public class OgrenciDevamsizlik
    {
        [Key]
        public int OgrenciDevamsizlikID{ get; set; }

        [DisplayName("Kurs")]
        public int KursID{ get; set; }

        [DisplayName("Dönem")]
        public int DonemID{ get; set; }

        [DisplayName("Öğrenci")]
        public int OgrenciID{ get; set; }

        public int ProgramID { get; set; }

        [DisplayName("Devam Durumu")]
        public bool DevamDurumu{ get; set; }

        [DisplayName("Devamsızlık Nedeni")]
        public int DevamsizlikNedeni{ get; set; } // Oluşturulan E-NUM İçerisindeki sayılar kaydedilecek

        public DateTime Tarih{ get; set; }
    }
}
