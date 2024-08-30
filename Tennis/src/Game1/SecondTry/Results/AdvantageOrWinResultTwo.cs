using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class AdvantageOrWinResultTwo : ResultTwo
{
    private int PlayerOneScore;
    private int PlayerTwoScore;

    public AdvantageOrWinResultTwo(int playerOneScore, int playerTwoScore)
    {
        PlayerOneScore = playerOneScore;
        PlayerTwoScore = playerTwoScore;
    }

    public string GetScoreAsText()
    {
        string score;
        var minusResult = PlayerOneScore - PlayerTwoScore;
        if (minusResult == 1)
        {
            score = "Advantage player1";
        }
        else if (minusResult == -1)
        {
            score = "Advantage player2";
        }
        else if (minusResult >= 2)
        {
            score = "Win for player1";
        }
        else
        {
            score = "Win for player2";
        }

        return score;
    }
}
