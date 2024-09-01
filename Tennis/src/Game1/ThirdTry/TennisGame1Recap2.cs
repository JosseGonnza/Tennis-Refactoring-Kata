namespace Tennis.Game1.ThirdTry;

public class TennisGame1Recap2 : ITennisGame
{
    private NewPlayer2 Player1;
    private NewPlayer2 Player2;
    private string player1Name;
    private string player2Name;

    public TennisGame1Recap2(string player1Name, string player2Name)
    {
        Player1 = new NewPlayer2(player1Name);
        Player2 = new NewPlayer2(player2Name);
    }

    public void WonPoint(string playerName)
    {
        if (playerName.Equals("player1"))
            Player1.AddPoint();
        else
            Player2.AddPoint();
    }

    public string GetScore()
    {
        return ArbiterThree.DeterminateResult(Player1.GetScore(), Player2.GetScore()).GetScoreAsText();
    }
}