namespace BeeCrowd.src.Resolutions.String;

public static class Beecrowd1871
{
    public static void ZeroIsWorthZero()
    {
        while (true)
        {
            string[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ');

            if (lineValues[0] == "0" && lineValues[1] == "0") break;

            string result = (int.Parse(lineValues[0]) + int.Parse(lineValues[1])).ToString().Replace("0", "");

            Console.WriteLine(result);
        }
    }
}
