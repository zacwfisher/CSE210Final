using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.WriteLine("Guess a number between 1 and 100:");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Guess again.");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Too high! Guess again.");
            }
            else
            {
                Console.WriteLine("congratulations! You guessed the magic number!");
            }
        }
        
    }
}