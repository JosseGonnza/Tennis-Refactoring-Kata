using Tennis.src.Game1.Models;

namespace Tennis.src.Game1.Results;

public class DrawResult : Result
{
    private Player Player1;
    private Player Player2;

    public DrawResult(Player player1, Player player2)
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
