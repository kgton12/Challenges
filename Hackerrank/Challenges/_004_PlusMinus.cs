
namespace Hackerrank.Challenges
{
    public class _004_Plus_Minus
    {
        public void PlusMinus(List<int> arr)
        {
            int n = arr.Count;
            double positive = 0;
            double negative = 0;
            double zero = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine((positive / n).ToString("F6"));
            Console.WriteLine((negative / n).ToString("F6"));
            Console.WriteLine((zero / n).ToString("F6"));
        }
    }
}
