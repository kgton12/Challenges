

namespace Hackerrank.Challenges
{
    public class _006_MiniMaxSum
    {
        public void MiniMaxSum(List<int> arr)
        {
            long min = 0;
            long max = 0;
            long sum = 0;
            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }

            min = arr[0];
            max = arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            minSum = sum - max;
            maxSum = sum - min;

            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
