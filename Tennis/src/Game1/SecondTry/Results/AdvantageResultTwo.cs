﻿using Tennis.src.Game1.SecondTry.Models;

namespace Tennis.src.Game1.SecondTry.Results;

public class AdvantageResultTwo : ResultTwo
{
    private NewPlayer Player1;
    private NewPlayer Player2;

    public AdvantageResultTwo(NewPlayer player1, NewPlayer player2)
    {
        Player1 = player1;
        Player2 = player2;
    }

    public string GetScoreAsText()
    {
        return Player1.GetScore() > Player2.GetScore() ? "Advantage player1" : "Advantage player2";
    }
}
