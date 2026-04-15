namespace CampusManagementSystem
{
    internal class Lecturer : Person
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Lecturer Info ---");
            base.DisplayInfo();
            Console.WriteLine($"Employee ID : {EmployeeId}");
            Console.WriteLine($"Department  : {Department}");
        }
    }
}