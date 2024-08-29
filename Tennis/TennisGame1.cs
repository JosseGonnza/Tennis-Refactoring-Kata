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
        string score = "";
        var tempScore = 0;
        if (IsDraw())
        {
            return DeterminateDrawResult();
        }

        if (_player1Score >= 4 || _player2Score >= 4)
        {
            return DetermineAdvantageOrWinResult();
        }

        return DeterminateOngoingResult(score);
    }

    private string DeterminateOngoingResult(string score)
    {
        return new OngoingResult(_player1Score, _player2Score).GetScoreAsText();
    }

    private string DetermineAdvantageOrWinResult()
    {
        return new AdvantageOrWinResult(_player1Score, _player2Score).GetScoreAsText();
    }

    private string DeterminateDrawResult()
    {
        return new DrawResult(_player1Score, _player2Score).GetScoreAsText();
    }

    private bool IsDraw()
    {
        return _player1Score == _player2Score;
    }
}

public interface Result
{
    public string GetScoreAsText();
}

public class DrawResult : Result
{
    private int Player1Score;
    private int Player2Score;

    public DrawResult(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        return Player1Score switch
        {
            0 => "Love-All",
            1 => "Fifteen-All",
            2 => "Thirty-All",
            _ => "Deuce",
        };
    }
}

public class AdvantageOrWinResult : Result
{
    private int Player1Score;
    private int Player2Score;

    public AdvantageOrWinResult(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        string score;
        var minusResult = Player1Score - Player2Score;
        if (minusResult == 1) score = "Advantage player1";
        else if (minusResult == -1) score = "Advantage player2";
        else if (minusResult >= 2) score = "Win for player1";
        else score = "Win for player2";
        return score;
    }
}

public class OngoingResult : Result
{
    private int Player1Score;
    private int Player2Score;

    public OngoingResult(int player1Score, int player2Score)
    {
        Player1Score = player1Score;
        Player2Score = player2Score;
    }

    public string GetScoreAsText()
    {
        return GetScoreAsString(Player1Score) + "-" + GetScoreAsString(Player2Score);
    }

    private static string GetScoreAsString(int score)
    {
        switch (score)
        {
            case 0:
                return "Love";
            case 1:
                return "Fifteen";
            case 2:
                return "Thirty";
            case 3:
                return "Forty";
        }

        return score.ToString();
    }
}