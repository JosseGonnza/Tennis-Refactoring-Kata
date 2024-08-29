using System;
using Tennis.src.Game1.Models;

namespace Tennis.src.Game1;

public class TennisGame1 : ITennisGame
{
    private Player Player1;
    private Player Player2;
    private string Player1Name;
    private string Player2Name;

    public TennisGame1(string player1Name, string player2Name)
    {
        Player1 = new Player(player1Name);
        Player2 = new Player(player2Name);
    }

    public void WonPoint(string playerName)
    {
        if (playerName.Equals("player1"))
        {
            Player1.AddPoint();
        }
        else
        {
            Player2.AddPoint();
        }

    }

    public string GetScore()
    {
        return Arbiter.DeterminateResult(Player1, Player2).GetScoreAsText();
    }
}
