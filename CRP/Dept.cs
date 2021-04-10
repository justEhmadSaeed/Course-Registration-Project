
namespace CRP
{
    class Dept
    {
        // Data members
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
        // Constructor initialize the class with an id and name
        public Dept(int dept_id, string dept_name)
        {
            this.ID = dept_id;
            this.Name = dept_name;
        }
        // Returns the formatted string
        public override string ToString()
        {
            return $"Deptarment ID: {ID.ToString(),27} | Deptarment Name: {Name,25}\n";
        }

    }
}
