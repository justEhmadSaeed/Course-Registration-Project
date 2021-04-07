
namespace CRP
{
    class Student : Person
    {
        private static int studentCount = 0;
        // Read-only member
        public static int stdCount
        {
            get => studentCount;
        }

        private Faculty faculty;
        private Dept dept;
        // Constructor initialize the class with an id, name, address, faculty & dept.
        public Student(int p_id, string p_name, Address p_address, Faculty p_faculty, Dept p_dept) : base(p_id, p_name, p_address)
        {
            faculty = p_faculty;
            dept = p_dept;
            studentCount++;
        }
        // Returns the formatted string
        public override string ToString()
        {
            return $"Student ID: {ID,30} | Student Name: {Name,30}\nFaculty Name: {faculty.Name,28} | Department Name: {dept.Name,27}\n";
        }
    }
}
