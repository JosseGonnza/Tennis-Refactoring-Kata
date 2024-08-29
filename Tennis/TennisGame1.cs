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

            var i = 1;
            {
                if (i == 1)
                {
                    tempScore = _player1Score;
                }
                else
                {
                    score += "-"; tempScore = _player2Score;
                }

                score = GetScoreAsString(score, tempScore);
            }

            i = 2;
            {
                if (i == 1)
                {
                    tempScore = _player1Score;
                }
                else
                {
                    score += "-"; tempScore = _player2Score;
                }

                score = GetScoreAsString(score, tempScore);
            }

            return score;
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

