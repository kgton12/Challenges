namespace CodeWars.Completed;

public class Quark(string color, string flavor)
{
    public string Color { get; set; } = color;
    public string Flavor { get; set; } = flavor;
    public double BaryonNumber => 1d / 3d;

    public void Interact(Quark quark) =>
        (quark.Color, Color) = (Color, quark.Color);
}