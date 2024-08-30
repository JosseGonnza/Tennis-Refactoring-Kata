using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class WinResultTwo : ResultTwo
{
    private NewPlayer Player1;
    private NewPlayer Player2;

    public WinResultTwo(NewPlayer player1, NewPlayer player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return Player1.GetScore() > Player2.GetScore() ? "Win for player1" : "Win for player2";
    }
}