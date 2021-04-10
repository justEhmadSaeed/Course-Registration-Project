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
        private static int count = 0;
        public static int courseCount
        {
            get => count;
        }
        // Constructor initialize the class with a code & name
        public Course(string code, string name)
        {
            courseCode = code;
            courseName = name;
            // Initialize a student array of length 15
            students = new Student[15];
            numberOfStudents = 0;
            count++;
        }
        public string getCourseCode()
        {
            return courseCode;
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
        // Drop Student from a course based on its ID
        public void dropStudent(int stdID)
        {
            int indexToRemove = 0;
            // If student is found
            for (; indexToRemove < numberOfStudents; ++indexToRemove)
                if (students[indexToRemove].ID == stdID)
                {
                    numberOfStudents--;
                    break;
                }
            // This loop will rearrange the students array such that the found index is removed
            for (; indexToRemove < numberOfStudents + 1; ++indexToRemove)
            {
                students[indexToRemove] = students[indexToRemove + 1];
            }

        }
        // Returns the formatted string
        public override string ToString()
        {
            string temp = $"Course Code: {courseCode,29} | Course Name: {courseName,31}\nRegistered Students: \n";
            // Incase no student is registered
            if (numberOfStudents == 0)
                temp += "No Students Registered.\n";
            else temp += $"No. {"Name",30}| {"ID",20}\n";
            for (int i = 0; i < numberOfStudents; ++i)
                temp += $"{i + 1,2}- {students[i].Name,30}| {students[i].ID,20} \n";

            return temp;
        }
    }
}
