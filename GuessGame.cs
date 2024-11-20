using Microsoft.AspNetCore.Mvc;
using System;

public class Guess
{
    private int _userGuess;
    private DateTime _guessTime;

    public int NumberToGuess { get; set; }
    public int Attempts { get; set; }

    public int UserGuess
    {
        get { return _userGuess; }
    }

    public DateTime GuessTime
    {
        get { return _guessTime; }
    }

    public Guess()
    {
        ResetGame();
    }

    public Guess(int userGuess)
    {
        _userGuess = userGuess;
        _guessTime = DateTime.Now;
        ResetGame();
    }

    public void ResetGame()
    {
        Attempts = 0;
        NumberToGuess = new Random().Next(1, 101);
    }

    public string CheckGuess(int userGuess)
    {
        _userGuess = userGuess;
        _guessTime = DateTime.Now;
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