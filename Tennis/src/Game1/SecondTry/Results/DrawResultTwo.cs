using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class DrawResultTwo : ResultTwo
{
    private NewPlayer Player1;
    private NewPlayer Player2;

    public DrawResultTwo(NewPlayer player1, NewPlayer player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return Player1.GetScore() switch
        {
            0 => "Love-All",
            1 => "Fifteen-All",
            2 => "Thirty-All",
            _ => "Deuce",
        };
    }
}
