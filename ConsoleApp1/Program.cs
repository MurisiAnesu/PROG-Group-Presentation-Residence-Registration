namespace CampusManagementSystem
{
    class Program
    {
        // In-memory storage
        static List<Student> students = new List<Student>();
        static List<Lecturer> lecturers = new List<Lecturer>();
        static List<Course> courses = new List<Course>();

        static void Main()
        {
            bool running = true;

            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== CAMPUS MANAGEMENT SYSTEM =====");

                    Console.WriteLine("1. Register Student");
                    Console.WriteLine("2. Add Lecturer");
                    Console.WriteLine("3. Create Course");
                    Console.WriteLine("4. Assign Student to Course");
                    Console.WriteLine("5. Capture Marks");
                    Console.WriteLine("6. View Reports");
                    Console.WriteLine("7. Exit");

                    Console.Write("Select Option: ");
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
                        default: Console.WriteLine("Invalid option"); break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ReadKey();
                }
                finally
                {
                    Console.WriteLine("\nOperation completed.");
                }
            }
        }

        // ---------------- VALIDATION METHODS ----------------

        // Ensures only numeric input is accepted
        static int GetValidInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                try
                {
                    value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Enter numbers only.");
                }
            }
        }

        // Ensures non-empty string input
        static string GetValidString(string message)
        {
            string input;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input;

                Console.WriteLine("Input cannot be empty.");
            }
        }

        // Validates email format
        static string GetValidEmail(string message)
        {
            string email;
            while (true)
            {
                Console.Write(message);
                email = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
                    return email;

                Console.WriteLine("Invalid email format.");
            }
        }

        // Prevent duplicate student IDs
        static bool IsDuplicateId(int id)
        {
            return students.Exists(s => s.Id == id);
        }

        // ---------------- SYSTEM FUNCTIONS ----------------

        static void RegisterStudent()
        {
            var student = new Student();

            // Validate ID and prevent duplicates
            while (true)
            {
                int id = GetValidInt("Enter Student ID: ");

                if (IsDuplicateId(id))
                {
                    Console.WriteLine("ID already exists. Try another.");
                }
                else
                {
                    student.Id = id;
                    break;
                }
            }

            student.Name = GetValidString("Enter Name: ");
            student.Email = GetValidEmail("Enter Email: ");
            student.StudentNumber = GetValidString("Enter Student Number: ");

            students.Add(student);
            Console.WriteLine("Student registered successfully.");
        }

        static void AddLecturer()
        {
            var lecturer = new Lecturer();

            lecturer.Id = GetValidInt("Enter Lecturer ID: ");
            lecturer.Name = GetValidString("Enter Name: ");
            lecturer.Email = GetValidEmail("Enter Email: ");
            lecturer.EmployeeId = GetValidString("Enter Employee ID: ");
            lecturer.Department = GetValidString("Enter Department: ");

            lecturers.Add(lecturer);
            Console.WriteLine("Lecturer added successfully.");
        }

        static void CreateCourse()
        {
            var course = new Course();

            course.CourseName = GetValidString("Enter Course Name: ");

            courses.Add(course);
            Console.WriteLine("Course created successfully.");
        }

        static void AssignStudentToCourse()
        {
            string studNo = GetValidString("Enter Student Number: ");
            string courseName = GetValidString("Enter Course Name: ");

            var student = students.Find(s => s.StudentNumber == studNo);
            var course = courses.Find(c => c.CourseName == courseName);

            if (student == null || course == null)
            {
                Console.WriteLine("Student or course not found.");
                return;
            }

            course.Students.Add(student);
            student.Course = courseName;

            Console.WriteLine("Student assigned to course.");
        }

        static void CaptureMarks()
        {
            string studNo = GetValidString("Enter Student Number: ");
            var student = students.Find(s => s.StudentNumber == studNo);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            int mark = GetValidInt("Enter Mark: ");
            student.MarksList.Add(mark);

            Console.WriteLine("Mark captured successfully.");
        }

        static void ViewReports()
        {
            Console.WriteLine("\n===== STUDENT REPORTS =====");

            foreach (var s in students)
            {
                s.DisplayInfo();
                Console.WriteLine($"Average Mark : {s.CalculateAverage():0.00}");
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("\n===== LECTURER REPORTS =====");

            foreach (var l in lecturers)
            {
                l.DisplayInfo();
                Console.WriteLine("--------------------------------");
            }
        }
    }
}