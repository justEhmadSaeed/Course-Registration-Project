﻿
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
        // Constructor initialize the class with an id & name
        public Faculty(int faculty_id, string faculty_name)
        {
            this.ID = faculty_id;
            this.Name = faculty_name;
        }
        // Returns the formatted string
        public override string ToString()
        {
            return $"Faculty ID: {ID.ToString(), 30} | Faculty Name: {Name, 28}\n";
        }
    }
}
