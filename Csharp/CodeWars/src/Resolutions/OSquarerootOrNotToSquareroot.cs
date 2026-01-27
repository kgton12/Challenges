namespace CodeWars.Resolutions
{
    public class OSquarerootOrNotToSquareroot
    {
        public static int[] SquareOrSquareRoot(int[] array) =>
            [.. array
            .Select(x => double.IsInteger(Math.Sqrt(x)) ? Convert.ToInt32(Math.Sqrt(x)) : x * x)];
    }
}
