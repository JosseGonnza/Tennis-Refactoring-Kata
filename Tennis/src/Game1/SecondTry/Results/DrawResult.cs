using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class DrawResult : IResult
{
    private int PlayerOneScore;
    private int PlayerTwoScore;

    public DrawResult(int playerOneScore, int playerTwoScore)
    {
        PlayerOneScore = playerOneScore;
        PlayerTwoScore = playerTwoScore;
    }

    public string GetScoreAsText()
    {
        return PlayerOneScore switch
        {
            0 => "Love-All",
            1 => "Fifteen-All",
            2 => "Thirty-All",
            _ => "Deuce",
        };
    }
}
