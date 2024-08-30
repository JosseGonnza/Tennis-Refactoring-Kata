﻿namespace Tennis.src.Game1.SecondTry;

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
            score = DeterminateDrawResult();
        }
        else if (m_score1 >= 4 || m_score2 >= 4)
        {
            score = DeterminateAdvantageOrWinResult();
        }
        else
        {
            score = DeterminateOngoingResult(score);
        }
        return score;
    }

    private string DeterminateOngoingResult(string score)
    {
        return GetScoreAsString(score, m_score1) + "-" + GetScoreAsString(score, m_score2);
    }

    private static string GetScoreAsString(string score, int tempScore)
    {
        switch (tempScore)
        {
            case 0:
                score += "Love";
                break;
            case 1:
                score += "Fifteen";
                break;
            case 2:
                score += "Thirty";
                break;
            case 3:
                score += "Forty";
                break;
        }

        return score;
    }

    private string DeterminateAdvantageOrWinResult()
    {
        string score;
        var minusResult = m_score1 - m_score2;
        if (minusResult == 1)
        {
            score = "Advantage player1";
        }
        else if (minusResult == -1)
        {
            score = "Advantage player2";
        }
        else if (minusResult >= 2)
        {
            score = "Win for player1";
        }
        else
        {
            score = "Win for player2";
        }

        return score;
    }

    private string DeterminateDrawResult()
    {
        return m_score1 switch
        {
            0 => "Love-All",
            1 => "Fifteen-All",
            2 => "Thirty-All",
            _ => "Deuce",
        };
    }
}


