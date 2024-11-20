using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        Console.WriteLine("A random number between 1 and 100 has been generated.");

        Guess guessGame = new Guess();
        int userGuess;

        do
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out userGuess))
            {
                string result = guessGame.CheckGuess(userGuess);
                Console.WriteLine(result);

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the correct number.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true);

        Console.WriteLine($"You Won! The answer was {randomNumber}.");
        Console.WriteLine("Thank you for playing!");
    }
}