namespace CampusManagementSystem
{
    internal class Lecturer : Person
    {
        // Lecturer-specific properties
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\n------- Lecturer Information -------");
            base.DisplayInfo();
            Console.WriteLine($"Employee ID : {EmployeeId}");
            Console.WriteLine($"Department  : {Department}");
        }
    }
}