namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1042
{
    public static void SimpleSort()
    {
        string[] inputValues = (Console.ReadLine() ?? string.Empty).Split(' ');
        int[] arrayInt = inputValues.Select(x => Convert.ToInt32(x)).ToArray();
        int[] arrayOrdered = arrayInt.OrderBy(x => x).ToArray();

        foreach (var item in arrayOrdered)
            Console.WriteLine(item);

        Console.WriteLine("");

        foreach (var item in arrayInt)
            Console.WriteLine(item);
    }
}
