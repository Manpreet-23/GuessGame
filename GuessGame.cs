public class Guess
{
    public int NumberToGuess { get; set; }
    public int Attempts { get; set; }

    public Guess()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        Attempts = 0;
        NumberToGuess = new Random().Next(1, 101);
    }

    public string CheckGuess(int userGuess)
    {
        Attempts++;
        if (userGuess == NumberToGuess)
        {
            return $"Congratulations! You guessed the correct number: {NumberToGuess}. Do you want to play again? (yes/no)";
        }
        else if (userGuess < NumberToGuess)
        {
            return "Your guess is too low. Try again.";
        }
        else
        {
            return "Your guess is too high. Try again.";
        }
    }
}