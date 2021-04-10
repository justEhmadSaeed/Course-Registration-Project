
namespace CRP
{
    class Student
    {
        private int id;
        private string name;
        private Address address;
        private Dept dept;
        // Read-only member
        private static int studentCount = 0;
        public static int stdCount
        {
            get => studentCount;
        }
        public int ID
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        // Constructor initialize the class with an id, name, address & dept.
        public Student(int p_id, string p_name, Address p_address, Dept p_dept)
        {
            ID = p_id;
            Name = p_name;
            dept = p_dept;
            address = p_address;
            studentCount++;
        }
        // Returns the formatted string
        public override string ToString()
        {
            return $"Student Name: {Name,30} | Student ID: {ID,30}\nDepartment Name: {dept.Name,27}\nAddress: {address.ToString()}";
        }
    }
}
