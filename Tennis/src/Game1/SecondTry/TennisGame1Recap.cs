using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry;

public class TennisGame1Recap : ITennisGame
{
    private NewPlayer Player1;
    private NewPlayer Player2;
    private string player1Name;
    private string player2Name;

    public TennisGame1Recap(string player1Name, string player2Name)
    {
        Player1 = new NewPlayer(player1Name); 
        Player2 = new NewPlayer(player2Name);
    }

    public void WonPoint(string playerName)
    {
        if (playerName.Equals("player1"))
            Player1.AddPoint();
        else
            Player2.AddPoint();
    }

    public string GetScore()
    {
        return ArbiterTwo.DeterminateResult(Player1, Player2).GetScoreAsText();
    }
}