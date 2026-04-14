namespace ResidenceReigister
{
    internal class StudentResident
    {

        public string StudentNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ResidenceName { get; set; }
        public double BaseFee { get; set; } = 7000;



        public virtual double CalculateMonthlyFee()
        {
            return BaseFee;
        }




        public void DisplayInfo()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Number: {StudentNumber}");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Residence: {ResidenceName}");
            Console.WriteLine($"Fee: {CalculateMonthlyFee()}");



        }

        public void DisplayInfo(string heading)
        {
            Console.WriteLine($"\n==== {heading} ====");
            DisplayInfo();
        }


    }
}
