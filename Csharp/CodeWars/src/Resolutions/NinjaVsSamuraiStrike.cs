namespace CodeWars.Resolutions;

public class NinjaVsSamuraiStrike(string name)
{
    private readonly string name = name;

    public int Health { get; set; } = 100;

    public void Strike(NinjaVsSamuraiStrike enemy, int swings)
    {
        enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
    }
}
