using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursTakip.Modeller
{
    public class DbKurs
    {
        public int Id { get; set; }//PK (Otomatik Artan)
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public int? SehirId { get; set; }
        public int? IlceId { get; set; }
        public string? KursYeri { get; set; }
        public int? EgitmenId { get; set; }//FK (Yabancı Anahtar)
        public DbEgitmen Egitmen { get; set; } //navigation property
    }
}
