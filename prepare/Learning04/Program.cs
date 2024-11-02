class Program
{
    static void Main(string[] args)
    {
        // Math Assignment
        MathAssignment mathAssignment = new MathAssignment("Alice", "Algebra", "3.2", "1-10, 15-20");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Writing Assignment
        WritingAssignment writingAssignment = new WritingAssignment("Bob", "History", "The American Revolution");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}