using ResidenceReigister;

try
{
    Console.WriteLine("Select Student Type:");
    Console.WriteLine("1. Undergraduate");
    Console.WriteLine("2. Postgraduate");

    int choice = int.Parse(Console.ReadLine());

    StudentResident student;

    if (choice == 1)
    {
        var undergrad = new Undergraduate();

        Console.Write("Student Number: ");
        undergrad.StudentNumber = Console.ReadLine();

        Console.Write("Full Name: ");
        undergrad.FullName = Console.ReadLine();

        Console.Write("Gender: ");
        undergrad.Gender = Console.ReadLine();

        Console.Write("Residence: ");
        undergrad.ResidenceName = Console.ReadLine();

        Console.Write("Meal Plan Fee: ");
        undergrad.MealPlanFee = double.Parse(Console.ReadLine());

        student = undergrad;
    }
    else
    {
        var postgrad = new Postgraduate();

        Console.Write("Student Number: ");
        postgrad.StudentNumber = Console.ReadLine();

        Console.Write("Full Name: ");
        postgrad.FullName = Console.ReadLine();

        Console.Write("Gender: ");
        postgrad.Gender = Console.ReadLine();

        Console.Write("Residence: ");
        postgrad.ResidenceName = Console.ReadLine();

        Console.Write("Research Fee: ");
        postgrad.ResearchFee = double.Parse(Console.ReadLine());

        Console.Write("Private Room (true/false): ");
        postgrad.HasPrivateRoom = bool.Parse(Console.ReadLine());

        student = postgrad;
    }

    // Polymorphism in action
    student.CalculateMonthlyFee();
    student.DisplayInfo("Student Summary");
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Program finished.");
}


