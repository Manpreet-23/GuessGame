using System;

class Program
{
    static void Main(string[] args)
    {
        PlayGame();
    }

    static void PlayGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        Console.WriteLine("A random number between 1 and 100 has been generated.");

        Guess guessGame = new Guess();
        int userGuess;

        do
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine() ?? string.Empty;
            if (input != null && int.TryParse(input, out userGuess))
            {
                string result = guessGame.CheckGuess(userGuess);
                Console.WriteLine(result);

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the correct number.");
                    Console.WriteLine($"You won at: {DateTime.Now}");

                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true);

        Console.WriteLine($"You Won! The answer was {randomNumber}.");
        Console.WriteLine("Do you want to play again? (yes/no)");
        string playAgain = Console.ReadLine()?.ToLower() ?? "no";

        if (playAgain == "yes")
        {
            PlayGame();
        }
        else
        {
            Console.WriteLine("Thank you for playing!");
        }
    }
}