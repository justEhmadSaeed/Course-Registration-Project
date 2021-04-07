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
        private string streetNo;

        public Address(string p_city, string p_street)
        {
            this.city = p_city;
            this.streetNo = p_street;
        }
        public override string ToString()
        {
            return $"City: {city} || Street No. {streetNo}";
        }

    }
}
