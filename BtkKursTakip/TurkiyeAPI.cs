using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BtkKursTakip
{

    public class Sehir
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Ilce
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class APIResponse
    {
        public string status { get; set; }
        public object data { get; set; }
    }

    public class TurkiyeAPI
    {
        const string baseUrl = "https://turkiyeapi.dev/api/v1/";
        public static async Task<List<Sehir>> SehirleriGetir()
        {
            List<Sehir> list = new();

            HttpClient client = new HttpClient();

            HttpResponseMessage resp =  await client.GetAsync(baseUrl + "provinces?fields=id,name");

            if(resp.IsSuccessStatusCode)
            {
                string dataStr = await resp.Content.ReadAsStringAsync();

                APIResponse apiResponse = JsonSerializer.Deserialize<APIResponse>(dataStr);

                if (apiResponse.status == "OK")
                {
                    string data = apiResponse.data.ToString();

                    list = JsonSerializer.Deserialize<List<Sehir>>(data);
                }
            }

            return list;
        }
        public static async Task<List<Ilce>> IlceleriGetir(int sehirId)
        {
            List<Ilce> list = new();

            HttpClient client = new HttpClient();

            HttpResponseMessage resp = await client.GetAsync(baseUrl + 
                $"districts?provinceId={sehirId}&fields=id,name");

            if (resp.IsSuccessStatusCode)
            {
                string dataStr = await resp.Content.ReadAsStringAsync();

                APIResponse apiResponse = JsonSerializer.Deserialize<APIResponse>(dataStr);

                if (apiResponse.status == "OK")
                {
                    string data = apiResponse.data.ToString();

                    list = JsonSerializer.Deserialize<List<Ilce>>(data);
                }
            }

            return list;
        }
    }
}
