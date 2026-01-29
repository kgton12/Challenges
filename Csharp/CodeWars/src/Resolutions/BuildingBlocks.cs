namespace CodeWars.Resolutions;

public class BuildingBlocks(int[] args)
{
    private int Width { get; set; } = args[0];
    private int Length { get; set; } = args[1];
    private int Height { get; set; } = args[2];

    public int GetWidth() => Width;

    public int GetLength() => Length;

    public int GetHeight() => Height;

    public int GetVolume() => Width * Length * Height;

    public int GetSurfaceArea() => 2 * (Width * Length + Width * Height + Length * Height);
}