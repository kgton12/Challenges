namespace CodeWars.src.Resolutions
{
    public class SumOfDifferencesInArray
    {
        public static int SumOfDifferences(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return 0;

            var arrayDesc = arr.ToList().OrderByDescending(x => x).ToArray();

            int sum = 0;
            for (int i = 0; i < arrayDesc.Length - 1; i++)
                sum += arrayDesc[i] - arrayDesc[i + 1];

            return sum;
        }
    }
}
