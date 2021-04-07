using System;

namespace CRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding faculty
            Faculty f1 = new Faculty(1231423, "College of Computing");
            Console.WriteLine(f1.ToString());

            // Adding departments
            Dept d1 = new Dept(2323, "Computer Science");
            Console.WriteLine(d1.ToString());
            Dept d2 = new Dept(2424, "Computer Engineering");
            Console.WriteLine(d2.ToString());

            // Adding Department of the faculty
            DeptOfFaculty df1 = new DeptOfFaculty(f1);
            df1.addDept(d1);
            df1.addDept(d2);
            Console.WriteLine(df1.ToString());

            // Adding students
            Student s1 = new Student(411002209, "Abdullah alshehri", new Address("City 1", "Street 1"), f1, d1);
            Console.WriteLine(s1.ToString());
            Student s2 = new Student(411001134, "Abdulrahman Alotwi", new Address("City 1", "Street 2"), f1, d1);
            Console.WriteLine(s2.ToString());
            Student s3 = new Student(411001442, "Khalid Bedaiwi", new Address("City 2", "Street 3"), f1, d2);
            Console.WriteLine(s3.ToString());

            // Adding Course
            Course course = new Course("CP121", "Computer Programming");
            // Adding students in the course
            course.addStudent(s1);
            course.addStudent(s2);
            course.addStudent(s3);
            Console.WriteLine(course.ToString());

        }
    }
}
