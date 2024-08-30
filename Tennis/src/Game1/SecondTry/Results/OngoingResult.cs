using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class OngoingResult : IResult
{
    private int PlayerOneScore;
    private int PlayerTwoScore;

    public OngoingResult(int playerOneScore, int playerTwoScore)
    {
        PlayerOneScore = playerOneScore;
        PlayerTwoScore = playerTwoScore;
    }

    public string GetScoreAsText()
    {
        return GetScoreAsString(PlayerOneScore) + "-" + GetScoreAsString(PlayerTwoScore);
    }

    private static string GetScoreAsString(int score)
    {
        switch (score)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            case 3:
                return "Forty";
        }
        return score.ToString();
    }

}
