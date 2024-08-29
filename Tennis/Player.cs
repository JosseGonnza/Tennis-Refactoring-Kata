namespace Tennis;

public class Player
{
    public string Name;
    public int Score;

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void AddPoint()
    {
        Score++;
    }

    public int GetScore()
    {
        return Score;
    }
}