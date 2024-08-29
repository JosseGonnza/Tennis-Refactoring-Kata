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
        else if (player1Score >= 4 || player2Score >= 4)
        {
            return new AdvantageOrWinResult(player1Score, player2Score);
        }
        else
        {
            return new OngoingResult(player1Score, player2Score);
        }
    }
}