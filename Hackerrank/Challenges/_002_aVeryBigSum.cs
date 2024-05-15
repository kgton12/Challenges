
namespace Hackerrank.Challenges
{
    public class _002_aVeryBigSum
    {
        public long AVeryBigSum(List<long> ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
