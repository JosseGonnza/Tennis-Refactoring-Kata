namespace Tennis.src.Game1;

public class WinResult : Result
{
    private int Player1Score;
    private int Player2Score;

    public WinResult(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        return Player1Score > Player2Score ? "Win for player1" : "Win for player2";
    }
}