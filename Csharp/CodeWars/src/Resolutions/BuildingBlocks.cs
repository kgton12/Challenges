namespace CodeWars.Resolutions;

public class BuildingBlocks
{
    private int Width { get; set; }
    private int Length { get; set; }
    private int Height { get; set; }

    public BuildingBlocks(int[] args)
    {
        Width = args[0];
        Length = args[1];
        Height = args[2];
    }

    public int GetWidth() => Width;

    public int GetLength() => Length;

    public int GetHeight() => Height;

    public int GetVolume() => Width * Length * Height;

    public int GetSurfaceArea() => 2 * (Width * Length + Width * Height + Length * Height);
}