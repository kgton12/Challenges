namespace CodeWars.Completed;

public class AddLengthClass
{
    public static string[] AddLength(string str) =>
        [.. str.Split(" ").Select(x => $"{x} {x.Length}")];
}
