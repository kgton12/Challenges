
namespace Hackerrank.Challenges
{
    public class _003_DiagonalDifference
    {
        public int DiagonalDifference(List<List<int>> arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;
            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                leftDiagonal += arr[i][i];
                rightDiagonal += arr[i][n - i - 1];
            }

            return Math.Abs(leftDiagonal - rightDiagonal);
        }
    }
}
