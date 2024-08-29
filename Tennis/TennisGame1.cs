using Tennis.src.Game1;

namespace Tennis;

public class TennisGame1 : ITennisGame
{
    private int _player1Score = 0;
    private int _player2Score = 0;
    private string Player1Name;
    private string Player2Name;

    public TennisGame1(string player1Name, string player2Name)
    {
        Player1Name = player1Name;
        Player2Name = player2Name;
    }

    public void WonPoint(string playerName)
    {
        if (playerName == "player1")
            _player1Score++;
        else
            _player2Score++;
    }

    public string GetScore()
    {
        return Arbiter.DeterminateResult(_player1Score, _player2Score).GetScoreAsText();
    }
}
