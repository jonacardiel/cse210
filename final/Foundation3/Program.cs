class Program
{
    static void Main(string[] args)
    {
        // Create a Lecture event
        Lecture lecture = new Lecture
        {
            Title = "Programming with Classes",
            Description = "Learn the basics of C# methods.",
            Date = new DateTime(2023, 11, 25),
            Time = new TimeSpan(10, 0, 0),
            Address = new Address
            {
                StreetAddress = "123 Main St",
                City = "Rexburg",
                StateProvince = "ID",
                Country = "USA"
            },
            Speaker = "Bro Gibbons",
            Capacity = 100
        };

        // Print lecture details
        Console.WriteLine(lecture.GetFullDetails());

        // Create a Reception event
        Reception reception = new Reception
        {
            Title = "Holiday Party",
            Description = "Join us for a festive gathering.",
            Date = new DateTime(2023, 12, 20),
            Time = new TimeSpan(18, 0, 0),
            Address = new Address
            {
                StreetAddress = "456 Elm St",
                City = "Anytown",
                StateProvince = "CA",
                Country = "USA"
            },
            RSVPEmail = "party@example.com"
        };

        // Print reception details
        Console.WriteLine(reception.GetFullDetails());
    }
}