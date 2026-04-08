namespace CodeWars.Completed;

public static class FindOutWhetherTheShapeIsACube
{
    public static bool IsCube(double volume, double side) =>
        volume > 0 && side > 0 && Math.Pow(side, 3) == volume;
}
