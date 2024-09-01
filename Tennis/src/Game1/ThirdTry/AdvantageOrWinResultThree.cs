namespace Tennis.Game1.ThirdTry;

public class AdvantageOrWinResultThree : ThreeResult
{
    private int Player1Score;
    private int Player2Score;

    public AdvantageOrWinResultThree(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        string score;
        var minusResult = Player1Score - Player2Score;
        if (minusResult == 1) score = "Advantage player1";
        else if (minusResult == -1) score = "Advantage player2";
        else if (minusResult >= 2) score = "Win for player1";
        else score = "Win for player2";
        return score;
    }
}