namespace Tennis.Game1.ThirdTry;

public class OnGoingResultThree : ThreeResult
{
    private int Player1Score;
    private int Player2Score;

    public OnGoingResultThree(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }
    
    public string GetScoreAsText()
    {
        return GetScoreAsString(Player1Score) + "-" + GetScoreAsString(Player2Score);
    }
    
    private static string GetScoreAsString(int tempScore)
    {
        switch (tempScore)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            default:
                return "Forty";
        }
    }
}