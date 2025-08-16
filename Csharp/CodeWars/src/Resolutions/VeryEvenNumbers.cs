namespace CodeWars.src.Resolutions;

public class VeryEvenNumbers
{
    public static bool IsVeryEvenNumber(int number)
    {
        while (number > 9)
            number = number
                    .ToString()
                    .Sum(x => Convert.ToInt32(char.GetNumericValue(x)));

        return number % 2 == 0;
    }
}
