
namespace Hackerrank.Challenges
{
    public class _001_SimpleArraySum
    {
        public int SimpleArraySum(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
