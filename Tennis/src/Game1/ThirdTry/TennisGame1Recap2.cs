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
            return DeterminateDrawResult();
        }
        if (m_score1 >= 4 || m_score2 >= 4)
        {
            return DeterminateAdvantageOrWinResult();
        }

        return GetScoreAsString(m_score1, score) + "-" + GetScoreAsString(m_score2, score);
    }

    private static string GetScoreAsString(int tempScore, string score)
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
        if (minusResult == 1) score = "Advantage player1";
        else if (minusResult == -1) score = "Advantage player2";
        else if (minusResult >= 2) score = "Win for player1";
        else score = "Win for player2";
        return score;
    }

    private string DeterminateDrawResult()
    {
        return new DrawResultThree(m_score1, m_score2).GetScoreAsText();
    }
}

public interface ThreeResult
{
    public string GetScoreAsText();
}

public class DrawResultThree : ThreeResult
{
    private int Player1Score;
    private int Player2Score;

    public DrawResultThree(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        string score;
        switch (Player1Score)
        {
            case 0:
                score = "Love-All";
                break;
            case 1:
                score = "Fifteen-All";
                break;
            case 2:
                score = "Thirty-All";
                break;
            default:
                score = "Deuce";
                break;
        }
        return score;
    }
}