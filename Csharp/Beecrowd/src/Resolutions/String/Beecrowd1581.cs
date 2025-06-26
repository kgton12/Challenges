namespace BeeCrowd.src.Resolutions.String;

public static class Beecrowd1581
{
    public static void InternationalConversation()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int J = Convert.ToInt32(Console.ReadLine());

            List<string> lineValues = new List<string>();

            for (int index = 0; index < J; index++)
                lineValues.Add(Console.ReadLine() ?? string.Empty);

            bool hasDistinctValues = lineValues.Distinct().ToList().Count != 1;

            Console.WriteLine(hasDistinctValues ? "ingles" : lineValues.First().ToString());
        }
    }
}
