using Tennis.src.Game1.FirstTry.Models;

namespace Tennis.src.Game1.SecondTry;

public class TennisGame1Recap : ITennisGame
{
    private int m_score1 = 0;
    private int m_score2 = 0;
    private string player1Name;
    private string player2Name;

    public TennisGame1Recap(string player1Name, string player2Name)
    {
        this.player1Name = player1Name;
        this.player2Name = player2Name;
    }

    public void WonPoint(string playerName)
    {
        if (playerName == "player1")
            m_score1 += 1;
        else
            m_score2 += 1;
    }

    public string GetScore()
    {
        return ArbiterTwo.DeterminateResult(m_score1, m_score2).GetScoreAsText();
    }
}
