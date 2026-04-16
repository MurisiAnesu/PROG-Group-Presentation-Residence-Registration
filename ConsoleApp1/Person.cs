namespace CampusManagementSystem
{
    internal class Person
    {
        // Encapsulated properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Virtual method for polymorphism
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID    : {Id}");
            Console.WriteLine($"Name  : {Name}");
            Console.WriteLine($"Email : {Email}");
        }
    }
}