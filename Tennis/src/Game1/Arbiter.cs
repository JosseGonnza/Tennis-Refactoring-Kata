using System;

namespace Tennis.src.Game1;

class Arbiter
{
    // Utilizamos esta clase como factoría
    public static Result DeterminateResult(int player1Score, int player2Score)
    {
        if (player1Score == player2Score)
        {
            return new DrawResult(player1Score, player2Score);
        }
        else if (EitherPlayerHasAdvantage(player1Score, player2Score) && SomeIsAheadByOne(player1Score, player2Score))
        {
            return new AdvantageResult(player1Score, player2Score);
        }
        else if (EitherPlayerHasAdvantage(player1Score, player2Score))
        {
            return new WinResult(player1Score, player2Score);
        }
        else
        {
            return new OngoingResult(player1Score, player2Score);
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