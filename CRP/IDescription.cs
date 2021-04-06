using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRP
{
    interface IDescription
    {
        int ID
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
        string ToString();
    }

}
