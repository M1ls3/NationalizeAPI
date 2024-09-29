using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;

namespace NationalizeAPI
{
    public class APIHelper
    {
        public static async Task<Nationalize> GetNationalizeDataAsync(string name)
        {
            string url = $"https://api.nationalize.io/?name={name}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        Nationalize data = JsonConvert.DeserializeObject<Nationalize>(jsonResult);
                        return data;
                    }
                    else
                    {
                        throw new Exception($"API ERROR: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
