using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRP
{
    class DeptOfFaculty
    {
        private Faculty faculty;
        private Dept[] depts;
        private int deptCounts;

        public int getNumberofDepts()
        {
            return deptCounts;
        }
        public Dept[] getDepts()
        {
            return depts;
        }
        public void addDept(Dept dept)
        {
            depts[deptCounts] = dept;
        }
        public DeptOfFaculty(Faculty f)
        {
            faculty = f;
            this.deptCounts = 0;
            this.depts = new Dept[5];
            int[] arr = new int[5];
        }
        public override string ToString()
        {
            string temp = $"Faculty Name: {faculty.Name}\n";
            foreach (Dept dept in this.depts)
            {
                temp += $"Dept. ID: {dept.ID} || Dept. Name: {dept.Name}\n";
            }
            return temp;
        }
    }
}
