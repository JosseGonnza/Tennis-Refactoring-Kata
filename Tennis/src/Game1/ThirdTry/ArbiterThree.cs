using System;

namespace Tennis.Game1.ThirdTry;

public class ArbiterThree
{
    public static ThreeResult DeterminateResult(int m_score1, int m_score2)
    {
        string score = "";
        if (m_score1 == m_score2)
        {
            return new DrawResultThree(m_score1, m_score2);
        }
        if ((m_score1 >= 4 || m_score2 >= 4) && Math.Abs(m_score1 - m_score2) == 1)
        {
            return new AdvantageResultThree(m_score1, m_score2);
        }
        if (m_score1 >= 4 || m_score2 >= 4)
        {
            return new WinResultThree(m_score1, m_score2);
        }

        return new OnGoingResultThree(m_score1, m_score2);
    }    
}