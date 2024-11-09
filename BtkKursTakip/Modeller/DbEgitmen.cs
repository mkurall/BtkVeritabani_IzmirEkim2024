using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursTakip.Modeller
{
    public class DbEgitmen
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Ad { get; set; }  
        [MaxLength(50)]
        public string Soyad { get; set; }
        public List<DbKurs> Kurslar { get; set; } = new();//null

        [NotMapped]
        public string AdSoyad { get { return Ad + " " + Soyad; } }
    }
}
