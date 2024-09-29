using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NationalizeAPI
{
    public class Nationalize
    {
        public int id { get; set; }
        public int count { get; set; }
        public string name { get; set; }
        public List<CountryInfo> country { get; set; }

        public Nationalize() 
        {
            id = 0;
            count = 0;
            name = string.Empty;
            country = new List<CountryInfo>();
        }

        public Nationalize(int id, int count, string name, List<CountryInfo> country)
        {
            this.id = id;
            this.count = count;
            this.name = name;
            this.country = country;
        }

        public override string ToString()
        {

            string countrys = string.Empty;
            foreach (var country in country)
            {
                countrys += country + "\n";
            }
            return $"Name: {name}\nCount: {count}\nCountries:\n{countrys}";
        }
    }
}
