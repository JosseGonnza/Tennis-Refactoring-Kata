namespace Tennis.src.Game1.SecondTry.Models;

public class NewPlayer
{
    private string Name;
    private int Score;

    public NewPlayer(string name)
    {
        Name = name;
        Score = 0;
    }

    public int GetScore()
    {
        return Score;
    }

    public void AddPoint()
    {
        Score++;
    }
}