using Tennis.src.Game1.FirstTry.Results;

namespace Tennis.src.Game1.FirstTry.Models;

class Arbiter
{
    public static Result DeterminateResult(Player player1, Player player2)
    {
        if (player1.IsTiedWith(player2))
        {
            return new DrawResult(player1, player2);
        }
        else if (EitherPlayerHasAdvantage(player1, player2) && player1.IsAheadByOnePoint(player2))
        {
            return new AdvantageResult(player1, player2);
        }
        else if (EitherPlayerHasAdvantage(player1, player2))
        {
            return new WinResult(player1, player2);
        }
        else
        {
            return new OngoingResult(player1, player2);
        }
    }

    private static bool EitherPlayerHasAdvantage(Player player1, Player player2)
    {
        return player1.GetScore() >= 4 || player2.GetScore() >= 4;
    }
}