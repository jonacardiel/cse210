using System;

class GuessMyNumberGame
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber;
        int guess;
        int guessCount;

        while (true)
        {
            magicNumber = random.Next(1, 101);
            guessCount = 0;

            Console.WriteLine("Let's play Guess My Number!");

            while (true)
            {
                Console.Write("Enter your guess (1-100): ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                    break;
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "yes")
            {
                break;
            }
        }
    }
}