using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class Guess
{
    private int _userGuess;
    private DateTime _guessTime;
    private List<int> _guesses;

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

    public List<int> Guesses
    {
        get { return _guesses; }
    }

    public Guess()
    {
        _guesses = new List<int>();
        ResetGame();
    }

    public Guess(int userGuess)
    {
        _userGuess = userGuess;
        _guessTime = DateTime.Now;
        _guesses = new List<int> { userGuess };
        ResetGame();
    }

    public void ResetGame()
    {
        Attempts = 0;
        NumberToGuess = new Random().Next(1, 101);
        _guesses.Clear();
    }

    public string CheckGuess(int userGuess)
    {
        _userGuess = userGuess;
        _guessTime = DateTime.Now;

        if (_guesses.Contains(userGuess))
        {
            int index = _guesses.IndexOf(userGuess);
            int turnsAgo = _guesses.Count - index;
            return $"You guessed this number {turnsAgo} turns ago!";
        }

        _guesses.Add(userGuess);
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