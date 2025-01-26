
namespace Hackerrank.Challenges
{
    public class _009_RecursiveDigitSum
    {
        public int RecursiveDigitSum(string n, int k)
        {
            int[] arr = new int[k];

            for (int i = 0; i < k; i++)
            {
                arr[i] = int.Parse(n.Substring(i, 1));
            }

            return Sum(arr);
        }
        public static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if (sum < 10)
            {
                return sum;
            }
            else
            {
                arr = new int[(sum).ToString().Length];

                for (int i = 0; i < (sum).ToString().Length; i++)
                {
                    arr[i] = int.Parse((sum).ToString().Substring(i, 1));
                }

                return Sum(arr);
            }
        }
    }
}
