using System;
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
        else if (AnyPlayerHasAdvantage(player1Score, player2Score) && SomeIsAheadByOne(player1Score, player2Score))
        {
            return new AdvantageResultTwo(player1Score, player2Score);
        }
        else if (AnyPlayerHasAdvantage(player1Score, player2Score))
        {
            return new WinResultTwo(player1Score, player2Score);
        }
        else
        {
            return new OngoingResultTwo(player1Score, player2Score);
        }
    }

    private static bool SomeIsAheadByOne(int player1Score, int player2Score)
    {
        return Math.Abs(player1Score - player2Score) == 1;
    }

    private static bool AnyPlayerHasAdvantage(int player1Score, int player2Score)
    {
        return (player1Score >= 4 || player2Score >= 4);
    }
}