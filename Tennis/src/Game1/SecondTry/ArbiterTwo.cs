using Tennis.src.Game1.SecondTry.Models;
using Tennis.src.Game1.SecondTry.Results;

namespace Tennis.src.Game1.SecondTry;

class ArbiterTwo
{
    public static ResultTwo DeterminateResult(int player1Score, int player2Score)
    {
        if (player1Score == player2Score)
        {
            return new DrawResultTwo(player1Score, player2Score);
        }
        else if (player1Score >= 4 || player2Score >= 4)
        {
            return new AdvantageOrWinResultTwo(player1Score, player2Score);
        }
        else
        {
            return new OngoingResultTwo(player1Score, player2Score);
        }
    }
}