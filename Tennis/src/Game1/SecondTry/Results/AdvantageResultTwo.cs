using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class AdvantageResultTwo : ResultTwo
{
    private int PlayerOneScore;
    private int PlayerTwoScore;

    public AdvantageResultTwo(int playerOneScore, int playerTwoScore)
    {
        PlayerOneScore = playerOneScore;
        PlayerTwoScore = playerTwoScore;
    }

    public string GetScoreAsText()
    {
        return PlayerOneScore > PlayerTwoScore ? "Advantage player1" : "Advantage player2";
    }
}

public class WinResultTwo : ResultTwo
{
    private int PlayerOneScore;
    private int PlayerTwoScore;

    public WinResultTwo(int playerOneScore, int playerTwoScore)
    {
        PlayerOneScore = playerOneScore;
        PlayerTwoScore = playerTwoScore;
    }

    public string GetScoreAsText()
    {
        return PlayerOneScore > PlayerTwoScore ? "Win for player1" : "Win for player2";
    }
}