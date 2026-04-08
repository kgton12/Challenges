namespace CodeWars.Completed
{
    public class DifferenceOfSquaresClass
    {
        public static int DifferenceOfSquares(int n)
        {
            int sumSquared = (int)Math.Pow(Enumerable.Range(1, n).Sum(), 2);
            int sumOfSquares = Enumerable.Range(1, n).Sum(x => x * x);

            return sumSquared - sumOfSquares;
        }
    }
}