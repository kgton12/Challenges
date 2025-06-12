namespace BeeCrowd.src;

public class Beecrowd1318
{
    public static void FakeTickets()
    {
        while (true)
        {
            string[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ');
            int N = Convert.ToInt32(lineValues[0]);
            int M = Convert.ToInt32(lineValues[1]);

            if (N == 0 && M == 0) break;

            var tickets = (Console.ReadLine() ?? string.Empty).Trim().Split(' ').Select(s => Convert.ToInt32(s));

            var seen = new HashSet<int>();
            var duplicates = new HashSet<int>();

            foreach (var ticket in tickets)
            {
                if (!seen.Add(ticket))
                    duplicates.Add(ticket);
            }

            Console.WriteLine(duplicates.Count);
        }
    }
}
