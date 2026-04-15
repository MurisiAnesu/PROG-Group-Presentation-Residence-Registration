namespace CampusManagementSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Lecturer> lecturers = new List<Lecturer>();
        static List<Course> courses = new List<Course>();

        public void Main()
        {
            bool running = true;

            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("===== CAMPUS MANAGEMENT SYSTEM =====");
                    Console.ResetColor();

                    Console.WriteLine("1. Register Student");
                    Console.WriteLine("2. Add Lecturer");
                    Console.WriteLine("3. Create Course");
                    Console.WriteLine("4. Assign Student to Course");
                    Console.WriteLine("5. Capture Marks");
                    Console.WriteLine("6. View Reports");
                    Console.WriteLine("7. Exit");

                    Console.Write("\nSelect Option: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: RegisterStudent(); break;
                        case 2: AddLecturer(); break;
                        case 3: CreateCourse(); break;
                        case 4: AssignStudentToCourse(); break;
                        case 5: CaptureMarks(); break;
                        case 6: ViewReports(); break;
                        case 7: running = false; break;
                        default: Console.WriteLine("Invalid option!"); break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                finally
                {
                    Console.WriteLine("\n--- THE END ---\n");
                }
            }
        }

        // Register Student
        static void RegisterStudent()
        {
            var student = new Student();

            Console.Write("ID: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Email: ");
            student.Email = Console.ReadLine();

            Console.Write("Student Number: ");
            student.StudentNumber = Console.ReadLine();

            students.Add(student);
            Console.WriteLine("Student Registered Successfully!");
        }

        // Add Lecturer
        static void AddLecturer()
        {
            var lecturer = new Lecturer();

            Console.Write("ID: ");
            lecturer.Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            lecturer.Name = Console.ReadLine();

            Console.Write("Email: ");
            lecturer.Email = Console.ReadLine();

            Console.Write("Employee ID: ");
            lecturer.EmployeeId = Console.ReadLine();

            Console.Write("Department: ");
            lecturer.Department = Console.ReadLine();

            lecturers.Add(lecturer);
            Console.WriteLine("Lecturer Added Successfully!");
        }

        // Create Course
        static void CreateCourse()
        {
            var course = new Course();

            Console.Write("Course Name: ");
            course.CourseName = Console.ReadLine();

            courses.Add(course);
            Console.WriteLine("Course Created!");
        }

        // Assign Student
        static void AssignStudentToCourse()
        {
            Console.Write("Enter Student Number: ");
            string studNo = Console.ReadLine();

            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

            var student = students.Find(s => s.StudentNumber == studNo);
            var course = courses.Find(c => c.CourseName == courseName);

            if (student == null || course == null)
            {
                Console.WriteLine("Student or Course not found!");
                return;
            }

            course.Students.Add(student);
            student.Course = courseName;

            Console.WriteLine("Student Assigned to Course!");
        }

        // Capture Marks
        static void CaptureMarks()
        {
            Console.Write("Enter Student Number: ");
            string studNo = Console.ReadLine();

            var student = students.Find(s => s.StudentNumber == studNo);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            Console.Write("Enter Marks: ");
            student.Marks = double.Parse(Console.ReadLine());

            Console.WriteLine("Marks Captured!");
        }

        // View Reports
        static void ViewReports()
        {
            Console.WriteLine("\n===== STUDENTS =====");
            foreach (var s in students)
                s.DisplayInfo();

            Console.WriteLine("\n===== LECTURERS =====");
            foreach (var l in lecturers)
                l.DisplayInfo();
        }
    }
}