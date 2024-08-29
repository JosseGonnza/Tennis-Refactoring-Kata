namespace Tennis.src.Game1;

public class OngoingResult : Result
{
    private int Player1Score;
    private int Player2Score;

    public OngoingResult(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        return GetScoreAsString(Player1Score) + "-" + GetScoreAsString(Player2Score);
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