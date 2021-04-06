using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRP
{
    class Dept: IDescription
    {
        private int id;
        private string name;
        public int ID {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get => this.name;
            set
            {
                name = value; 
            }
        }
        public Dept(int dept_id, string dept_name)
        {
            this.ID = dept_id;
            this.Name = dept_name;
        }
        public string ToString()
        {
            return "Dept. ID: " + ID.ToString() + "|| Dept. Name: " + Name; 
        }

    }
}
