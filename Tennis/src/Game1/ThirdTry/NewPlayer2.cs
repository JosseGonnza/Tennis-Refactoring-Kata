namespace Tennis.Game1.ThirdTry;

public class NewPlayer2
{
    private string PlayerName;
    private int PlayerScore;

    public NewPlayer2(string playerName)
    {
        PlayerName = playerName;
        PlayerScore = 0;
    }

    public void AddPoint()
    {
        PlayerScore++;
    }

    public int GetScore()
    {
        return PlayerScore;
    }
}