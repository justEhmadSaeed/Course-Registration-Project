
namespace CRP
{
    class Person : IDescription
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
        private Address address;
        // Constructor initialize the class with an id, name and address
        public Person(int p_id, string p_name, Address p_address)
        {
            this.Name = p_name;
            this.ID = p_id;
            this.address = p_address;
        }
        // Returns the formatted string
        public override string ToString()
        {
            return $"Person ID: {ID} | Person Name: {Name}\n {address.ToString()}";
        }
    }
}
