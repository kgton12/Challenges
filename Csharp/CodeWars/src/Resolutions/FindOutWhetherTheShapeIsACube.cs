namespace CodeWars.src.Resolutions;

public class FindOutWhetherTheShapeIsACube
{
    public static bool IsCube(double volume, double side) =>
        volume > 0 && side > 0 && Math.Pow(side, 3) == volume;
}
