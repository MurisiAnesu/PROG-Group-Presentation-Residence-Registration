namespace CampusManagementSystem
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public string Course { get; set; }
        public double Marks { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Student Info ---");
            base.DisplayInfo();
            Console.WriteLine($"Student No : {StudentNumber}");
            Console.WriteLine($"Course     : {Course}");
            Console.WriteLine($"Marks      : {Marks}");
        }
    }
}