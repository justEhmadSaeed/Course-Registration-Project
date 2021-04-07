using System;

namespace CRP
{
    class Course
    {
        // Data members
        private string courseCode;
        private string courseName;
        private Student[] students;
        private int numberOfStudents;
        // Constructor initialize the class with a code & name
        public Course(string code, string name)
        {
            courseCode = code;
            courseName = name;
            // Initialize a student array of length 15
            students = new Student[15];
            numberOfStudents = 0;
        }
        // Returns the number of registered students
        public int getNumberofStudents()
        {
            return numberOfStudents;
        }
        // Returns the array of students
        public Student[] getStudents()
        {
            return students;
        }
        // Add students in the course
        public void addStudent(Student p_student)
        {
            // preventing from accessing out of bound indices
            if (numberOfStudents < 15)
            {
                students[numberOfStudents] = p_student;
                numberOfStudents++;
            }
            else Console.WriteLine("ERR: No Space for the upcoming Student Record.");
        }
        // Returns the formatted string
        public override string ToString()
        {
            string temp = $"Course Code: {courseCode, 29} | Course Name: {courseName,31}\nRegistered Students: \n";
            for (int i = 0; i < numberOfStudents; ++i)
            {
                temp += $"{i+1}-  {students[i].Name}\n";
            }
            return temp;
        }
    }
}
