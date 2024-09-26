using System;

class Program
{
    static void Main()
    {
        // Get the grade percentage from the user
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (optional stretch challenge)
        string sign = "";
        if (letter != "A" && letter != "F" && gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (letter != "F" && gradePercentage % 10 < 3)
        {
            sign = "-";
        }

        // Display the letter grade and sign (optional stretch challenge)
        Console.WriteLine("Your letter grade is: " + letter + sign);

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep working hard, you'll get there next time!");
        }
    }
}