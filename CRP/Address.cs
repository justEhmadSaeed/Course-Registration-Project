using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRP
{
    class Address
    {
        private string city;
        private string street;

        public Address(string p_city, string p_street)
        {
            this.city = p_city;
            this.street = p_street;
        }
        public override string ToString()
        {
            return $"\nCity: {city,37}  | Street: {street,34}";
        }

    }
}
