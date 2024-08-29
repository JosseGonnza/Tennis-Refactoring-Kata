namespace Tennis
{
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
                return DrawResult();
            }

            if (_player1Score >= 4 || _player2Score >= 4)
            {
                return AdvantageOrWinResult();
            }

            return ResultPerPoint(score);
        }

        private string ResultPerPoint(string score)
        {
            return GetScoreAsString(_player1Score) + "-" + GetScoreAsString(_player2Score);
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

        private string AdvantageOrWinResult()
        {
            string score;
            var minusResult = _player1Score - _player2Score;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        private string DrawResult()
        {
            return _player1Score switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce",
            };
        }

        private bool IsDraw()
        {
            return _player1Score == _player2Score;
        }
    }
}

