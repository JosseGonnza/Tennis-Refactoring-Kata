using Tennis.src.Game1.Models;

namespace Tennis.src.Game1.Results;

public class OngoingResult : Result
{
    private Player Player1;
    private Player Player2;

    public OngoingResult(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return GetScoreAsString(Player1.GetScore()) + "-" + GetScoreAsString(Player2.GetScore());
    }

    public static string GetScoreAsString(int score)
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