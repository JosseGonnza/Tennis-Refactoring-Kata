using Tennis.src.Game1.Models;

namespace Tennis.src.Game1.Results;

public class AdvantageResult : Result
{
    private Player Player1;
    private Player Player2;

    public AdvantageResult(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return Player1.GetScore() > Player2.GetScore() ? "Advantage player1" : "Advantage player2";
    }
}
