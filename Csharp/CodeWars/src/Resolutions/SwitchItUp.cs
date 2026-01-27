namespace CodeWars.Resolutions;

public class SwitchItUpClass
{
    public static string SwitchItUp(int number)
    {
        Dictionary<int, string> numbersInWords = new()
        {
            { 0, "Zero" },
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" }
        };

        return numbersInWords[number];
    }
}
