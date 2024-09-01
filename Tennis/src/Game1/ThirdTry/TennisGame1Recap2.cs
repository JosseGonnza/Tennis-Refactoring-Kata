using System;

namespace Tennis.Game1.ThirdTry;

public class TennisGame1Recap2 : ITennisGame
{
    private int m_score1 = 0;
    private int m_score2 = 0;
    private string player1Name;
    private string player2Name;

    public TennisGame1Recap2(string player1Name, string player2Name)
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
            return new DrawResultThree(m_score1, m_score2).GetScoreAsText();
        }
        if ((m_score1 >= 4 || m_score2 >= 4) && Math.Abs(m_score1 - m_score2) == 1)
        {
            return new AdvantageResultThree(m_score1, m_score2).GetScoreAsText();
        }
        if (m_score1 >= 4 || m_score2 >= 4)
        {
            return new WinResultThree(m_score1, m_score2).GetScoreAsText();
        }

        return new OnGoingResultThree(m_score1, m_score2).GetScoreAsText();
    }
}