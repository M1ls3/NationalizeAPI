using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalizeAPI
{
    public class CountryInfo
    {
        public int id { get; set; }
        public string country_id { get; set; }
        public double probability { get; set; }

        public CountryInfo()
        {
            id = 0;      
            country_id = string.Empty;
            probability = 0.0;
        }

        public CountryInfo(int id, string country_id, double probability)
        {
            this.id = id;
            this.country_id = country_id;
            this.probability = probability;
        }

        public override string ToString()
        {
            return $"{country_id} (Probability: {probability})";
        }
    }
}
