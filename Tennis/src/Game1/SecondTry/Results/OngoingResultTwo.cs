using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class OngoingResultTwo : ResultTwo
{
    private NewPlayer Player1;
    private NewPlayer Player2;

    public OngoingResultTwo(NewPlayer player1, NewPlayer player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return GetScoreAsString(Player1.GetScore()) + "-" + GetScoreAsString(Player2.GetScore());
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
