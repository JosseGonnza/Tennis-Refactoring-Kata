using System;

namespace Tennis.src.Game1;

class Arbiter
{
    // Utilizamos esta clase como factoría
    public static Result DeterminateResult(Player player1, Player player2)
    {
        if (player1.IsTiedWith(player2))
        {
            return new DrawResult(player1.GetScore(), player2.GetScore());
        }
        else if (EitherPlayerHasAdvantage(player1.GetScore(), player2.GetScore()) && SomeIsAheadByOne(player1.GetScore(), player2.GetScore()))
        {
            return new AdvantageResult(player1.GetScore(), player2.GetScore());
        }
        else if (EitherPlayerHasAdvantage(player1.GetScore(), player2.GetScore()))
        {
            return new WinResult(player1.GetScore(), player2.GetScore());
        }
        else
        {
            return new OngoingResult(player1.GetScore(), player2.GetScore());
        }
    }

    private static bool SomeIsAheadByOne(int player1Score, int player2Score)
    {
        return Math.Abs(player1Score - player2Score) == 1;
    }

    private static bool EitherPlayerHasAdvantage(int player1Score, int player2Score)
    {
        return player1Score >= 4 || player2Score >= 4;
    }
}