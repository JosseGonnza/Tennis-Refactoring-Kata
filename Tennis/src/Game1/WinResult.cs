namespace Tennis.src.Game1;

public class WinResult : Result
{
    private Player Player1;
    private Player Player2;

    public WinResult(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return Player1.GetScore() > Player2.GetScore() ? "Win for player1" : "Win for player2";
    }
}