using System;

namespace CRP
{
    class DeptOfFaculty
    {
        // Data members
        private Faculty faculty;
        private Dept[] depts;
        private int deptCounts;
        // Constructor initialize the class with a faculty
        public DeptOfFaculty(Faculty f)
        {
            faculty = f;
            this.deptCounts = 0;
            this.depts = new Dept[5];
            int[] arr = new int[5];
        }
        public int getNumberofDepts()
        {
            return deptCounts;
        }
        public Dept[] getDepts()
        {
            return depts;
        }
        // Add department into the class
        public void addDept(Dept dept)
        {
            // preventing from accessing out of bound indices
            if (deptCounts < 5)
            {
                depts[deptCounts] = dept;
                deptCounts++;
            }
            else Console.WriteLine("ERR: No Space for upcoming Department Record.");
        }
        // Returns the formatted string
        public override string ToString()
        {
            string temp = $"\nFaculty Name: {faculty.Name}\nDepartments of Faculty: \n";
            for (int i = 0; i < deptCounts; ++i)
            {
                temp += $"{i+1}- {depts[i].Name}\n";
            }
            return temp;
        }
    }
}
