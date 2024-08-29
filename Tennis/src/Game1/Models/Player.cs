using System;

namespace Tennis.src.Game1.Models;

public class Player
{
    public string Name;
    public int Score;

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void AddPoint()
    {
        Score++;
    }

    public int GetScore()
    {
        return Score;
    }

    public bool IsTiedWith(Player otherPlayer)
    {
        return Score == otherPlayer.Score;
    }

    public bool IsAheadByOnePoint(Player otherPlayer)
    {
        return Math.Abs(Score - otherPlayer.Score) == 1;
    }
}