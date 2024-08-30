using System;

namespace Tennis.src.Game1.SecondTry.Models;

public class NewPlayer
{
    private string Name;
    private int Score;

    public NewPlayer(string name)
    {
        Name = name;
        Score = 0;
    }

    public int GetScore()
    {
        return Score;
    }

    public void AddPoint()
    {
        Score++;
    }

    public bool IsTiedWith(NewPlayer otherPlayer)
    {
        return Score == otherPlayer.Score;
    }

    public bool IsAheadByOnePoint(NewPlayer otherPlayer)
    {
        return Math.Abs(Score - otherPlayer.Score) == 1;
    }
}