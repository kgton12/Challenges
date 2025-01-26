
namespace Hackerrank.Challenges
{
    public class _005_StairCase
    {
        public void StairCase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
