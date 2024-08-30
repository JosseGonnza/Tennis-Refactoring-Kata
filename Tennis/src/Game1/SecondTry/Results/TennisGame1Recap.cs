using System.Reflection.Metadata.Ecma335;

namespace Tennis.src.Game1.SecondTry.Results;

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
        string score = "";
        if (m_score1 == m_score2)
        {
            return DeterminateDrawResult();
        }
        if (m_score1 >= 4 || m_score2 >= 4)
        {
            return DeterminateAdvantageOrWinResult();
        }
        return DeterminateOngoingResult(score);
    }

    private string DeterminateOngoingResult(string score)
    {
        return new OngoingResult(m_score1, m_score2).GetScoreAsText();
    }


    private string DeterminateAdvantageOrWinResult()
    {
        return new AdvantageOrWinResult(m_score1, m_score2).GetScoreAsText();
    }

    private string DeterminateDrawResult()
    {
        return new DrawResult(m_score1, m_score2).GetScoreAsText();
    }
}
