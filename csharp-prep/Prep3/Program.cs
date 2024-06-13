using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = -1;

        // Loops until guessed correctly
        while (guess != magicNumber)
        {
            // Ask for their guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // See if guess is higher, lower, or correct
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
                Console.WriteLine("You guessed it");
            }

        }
    }
}