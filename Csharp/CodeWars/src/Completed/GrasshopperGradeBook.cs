namespace CodeWars.Completed
{
    public class GrasshopperGradeBook
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            int avg = (int)new int[] { s1, s2, s3 }.Average();

            return avg switch
            {
                >= 90 and <= 100 => 'A',
                >= 80 and < 90 => 'B',
                >= 70 and < 80 => 'C',
                >= 60 and < 70 => 'D',
                < 60 => 'F',
                _ => throw new ArgumentOutOfRangeException(nameof(avg), "Invalid average score")
            };
        }
    }
}
