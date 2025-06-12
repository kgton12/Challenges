namespace CodeWars.src.Resolutions;

public class GrasshopperTerminalGame1(string name = "Hero")
{
    public string Name { get; set; } = name;
    public string Position { get; set; } = "00";
    public float Health { get; set; } = 100;
    public float Damage { get; set; } = 5;
    public int Experience { get; set; } = 0;
}