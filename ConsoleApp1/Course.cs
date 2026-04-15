namespace CampusManagementSystem
{
    internal class Course
    {
        public string CourseName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}