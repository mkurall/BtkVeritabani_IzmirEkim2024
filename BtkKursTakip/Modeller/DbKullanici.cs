using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursTakip.Modeller
{
    public enum YetkiTuru { Yonetici = 0, Kullanici = 1};
    public class DbKullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public YetkiTuru Yetki { get; set; } // 0 - Yönetici 1-Normal Kullanıcı
    }
}
