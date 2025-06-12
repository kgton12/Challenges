namespace BeeCrowd.src.Resolutions
{
    public class Beecrowd1216
    {
        public static void GetlineOne()
        {
            List<int> distanceList = new List<int>();
            while (true)
            {
                string nameInput = Console.ReadLine() ?? string.Empty;
                if (nameInput.Trim() == string.Empty) break;

                int distance = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

                distanceList.Add(distance);
            }
            Console.WriteLine($"{distanceList.Average():F1}");
        }
    }
}
