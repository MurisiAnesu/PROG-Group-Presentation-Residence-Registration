namespace CampusManagementSystem
{
    internal class Student : Person
    {
        // Student-specific properties
        public string StudentNumber { get; set; }
        public string Course { get; set; }

        // List to store multiple subject marks
        public List<int> MarksList { get; set; } = new List<int>();

        // Method to calculate average marks with divide-by-zero protection
        public double CalculateAverage()
        {
            try
            {
                return MarksList.Sum() / (double)MarksList.Count;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        // Override DisplayInfo method (Polymorphism)
        public override void DisplayInfo()
        {
            Console.WriteLine("\n------- Student Information -------");
            base.DisplayInfo();
            Console.WriteLine($"Student Number : {StudentNumber}");
            Console.WriteLine($"Course         : {Course}");
        }
    }
}