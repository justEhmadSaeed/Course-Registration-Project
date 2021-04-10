using System;

namespace CRP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            Program p = new Program();
            Course[] courses = new Course[10];
            Student[] students = new Student[20];
            while (!isExit)
            {
                p.printMenu();
                int option = 0;
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (option < 0 || option > 6)
                        throw new Exception();
                }
                catch (Exception e)
                {
                    // Exception will be triggered in case an invalid input is entered.
                    Console.WriteLine("Option number must be between 0 and 6.\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                switch (option)
                {
                    case 0:
                        isExit = true;
                        Console.WriteLine("Exiting PROGRAM ....");
                        break;
                    case 1:
                        p.addStudent(students);
                        break;
                    case 2:
                        p.viewStudents(students);
                        break;
                    case 3:
                        p.addCourse(courses);
                        break;
                    case 4:
                        p.viewCourses(courses);
                        break;
                    case 5:
                        p.registerStudent(students, courses);
                        break;
                    case 6:
                        p.dropStudent(students, courses);
                        break;
                    default:
                        Console.WriteLine("Option number must be between 0 and 6.\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
                //Console.WriteLine(option.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        // Print the menu function
        public void printMenu()
        {
            Console.Clear();
            Console.WriteLine("\n----- WELCOME TO COURSE REGISTRATION SYSTEM -----\n");
            Console.WriteLine("(1) ADD Student             | (2) View Students ");
            Console.WriteLine("(3) ADD Course              | (4) View Courses ");
            Console.WriteLine("(5) ADD Student to a course | (6) Drop Student from a course ");
            Console.WriteLine("(0) Exit the Program");
            Console.WriteLine("Choose an option number: ");
        }
        // Add student into the list
        public void addStudent(Student[] students)
        {
            int id, deptCode;
            string name, deptName, city, street;
            try
            {
                Console.WriteLine("Enter Student Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student ID(numbers only): ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Department Name: ");
                deptName = Console.ReadLine();
                Console.WriteLine("Enter Department Code(numbers only): ");
                deptCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student City: ");
                city = Console.ReadLine();
                Console.WriteLine("Enter Student Street Address: ");
                street = Console.ReadLine();
            }
            catch (Exception e)
            {
                // Exception will be triggered in case an invalid input is entered.
                Console.WriteLine("Only Numbers are allowed.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
            // Student will be added to students list in case everything goes right.
            students[Student.stdCount] = new Student(id, name,
                new Address(city, street), new Dept(deptCode, deptName));
            Console.WriteLine("Student Added Successfully.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        // View Students function
        public void viewStudents(Student[] students)
        {
            if (Student.stdCount == 0)
                Console.WriteLine("No Students available.");
            for (int i = 0; i < Student.stdCount; ++i)
            {
                Console.WriteLine($"\nSTUDENT {i + 1} INFORMATION");
                Console.WriteLine(students[i].ToString());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        // Add course into the courses list
        public void addCourse(Course[] courses)
        {
            string code, name;
            Console.WriteLine("Enter Course Code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter Course Name: ");
            name = Console.ReadLine();
            courses[Course.courseCount] = new Course(code, name);
            Console.WriteLine("Course Added Successfully.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        // View courses function
        public void viewCourses(Course[] courses)
        {
            if (Course.courseCount == 0)
                Console.WriteLine("No Courses available.");
            for (int i = 0; i < Course.courseCount; ++i)
            {
                Console.WriteLine($"\nCOURSE {i + 1} INFORMATION");
                Console.WriteLine(courses[i].ToString());
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        // Register student into a course
        public void registerStudent(Student[] students, Course[] courses)
        {
            int stdID, studentIndex, courseIndex;
            string courseCode;
            try
            {
                Console.WriteLine("Enter Student ID(numbers only): ");
                stdID = Convert.ToInt32(Console.ReadLine());
                studentIndex = studentSearch(students, stdID);
                if (studentIndex == -1)
                {
                    // If student is not present in the student list, terminate the function
                    Console.WriteLine("Student does not exist.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Enter Course Code: ");
                courseCode = Console.ReadLine();
                courseIndex = courseSearch(courses, courseCode);
                if (courseIndex == -1)
                {
                    // If course is not present in the courses list, terminate the function
                    Console.WriteLine("Course does not exist.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                if (courseStudentSearch(courses[courseIndex], stdID) != -1)
                {
                    // If student is already registered in the course, terminate the function
                    Console.WriteLine("Student is already registered in the current course.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                courses[courseIndex].addStudent(students[studentIndex]);
            }
            catch (Exception e)
            {
                // Exception will be triggered in case an invalid input is entered.
                Console.WriteLine("Only Numbers are allowed.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Student Registered Successfully.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void dropStudent(Student[] students, Course[] courses)
        {
            int stdID, studentIndex, courseIndex;
            string courseCode;
            try
            {
                Console.WriteLine("Enter Student ID(numbers only): ");
                stdID = Convert.ToInt32(Console.ReadLine());
                studentIndex = studentSearch(students, stdID);
                if (studentIndex == -1)
                {
                    // If student is not present in the student list, terminate the function
                    Console.WriteLine("Student does not exist.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Enter Course Code: ");
                courseCode = Console.ReadLine();
                courseIndex = courseSearch(courses, courseCode);
                if (courseIndex == -1)
                {
                    // If course is not present in the courses list, terminate the function
                    Console.WriteLine("Course does not exist.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                if (courseStudentSearch(courses[courseIndex], stdID) == -1)
                {
                    // If student is not registered in the course, it cannot be dropped out of it
                    // so, terminate the function
                    Console.WriteLine("Student is not registered in the current course.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                courses[courseIndex].dropStudent(stdID);
            }
            catch (Exception e)
            {
                // Exception will be triggered in case an invalid input is entered.
                Console.WriteLine("Only Numbers are allowed.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Student dropped the course Successfully.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        // searching studentID from the students list
        public int studentSearch(Student[] students, int stdID)
        {
            for (int i = 0; i < Student.stdCount; ++i)
                if (students[i].ID == stdID)
                    return i;
            return -1;
        }
        // searching course code from the courses list
        public int courseSearch(Course[] courses, string code)
        {
            for (int i = 0; i < Course.courseCount; ++i)
                if (String.Equals(courses[i].getCourseCode(), code))
                    return i;
            return -1;
        }
        // searching studentID from a course's students list
        public int courseStudentSearch(Course course, int id)
        {
            for (int i = 0; i < course.getNumberofStudents(); ++i)
                if (course.getStudents()[i].ID == id)
                    return i;
            return -1;
        }
    }
}
