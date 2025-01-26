
namespace Hackerrank.Challenges
{
    public class _007_BirthdayCakeCandles
    {
        public int BirthdayCakeCandles(List<int> candles)
        {
            int max = 0;
            int count = 0;

            foreach (var item in candles)
            {
                if (item > max)
                {
                    max = item;
                    count = 1;
                }
                else if (item == max)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
