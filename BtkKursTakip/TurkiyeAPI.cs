using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursTakip
{

    public class Sehir
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TurkiyeAPI
    {
        const string baseUrl = "https://turkiyeapi.dev/api/v1/";
        public static async Task<List<Sehir>> SehirleriGetir()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage resp =  await client.GetAsync(baseUrl + "provinces");

            if(resp.IsSuccessStatusCode)
            {
                string dataStr = await resp.Content.ReadAsStringAsync();

            }

            return new List<Sehir>();
        }
    }
}
