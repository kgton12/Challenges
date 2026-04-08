namespace CodeWars.Completed
{
    public class SumWithoutHighestAndLowestNumber
    {
        public static int Sum(int[] numbers) =>
            numbers != null ? numbers.OrderBy(x => x).Skip(1).Take(numbers.Length - 2).Sum() : 0;
    }
}
