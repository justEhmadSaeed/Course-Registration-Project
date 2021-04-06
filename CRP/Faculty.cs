using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRP
{
    class Faculty : IDescription
    {
        private int id;
        private string name;
        public int ID
        {
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

        public Faculty(int faculty_id, string faculty_name)
        {
            this.ID = faculty_id;
            this.Name = faculty_name;
        }
        public string ToString()
        {
            return "Faculty ID: " + ID.ToString() + "|| Faculty Name: " + Name;
        }
    }
}
