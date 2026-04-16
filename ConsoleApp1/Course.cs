namespace CampusManagementSystem
{
    internal class Course
    {
        // Course name
        public string CourseName { get; set; }

        // List of students assigned to the course
        public List<Student> Students { get; set; } = new List<Student>();
    }
}