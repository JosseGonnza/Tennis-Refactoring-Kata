using Tennis.src.Game1.SecondTry.Results;

namespace Tennis.src.Game1.SecondTry.Models;

class ArbiterTwo
{
    public static ResultTwo DeterminateResult(NewPlayer player1, NewPlayer player2)
    {
        if (player1.IsTiedWith(player2))
        {
            return new DrawResultTwo(player1, player2);
        }
        else if (AnyPlayerHasAdvantage(player1.GetScore(), player2.GetScore()) && player1.IsAheadByOnePoint(player2))
        {
            return new AdvantageResultTwo(player1, player2);
        }
        else if (AnyPlayerHasAdvantage(player1.GetScore(), player2.GetScore()))
        {
            return new WinResultTwo(player1, player2);
        }
        else
        {
            return new OngoingResultTwo(player1, player2);
        }
    }

    private static bool AnyPlayerHasAdvantage(int player1Score, int player2Score)
    {
        return player1Score >= 4 || player2Score >= 4;
    }
}