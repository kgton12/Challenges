namespace CodeWars.src.Resolutions;

public class PreviousMultipleOfThreeClass
{
    public static int? PreviousMultipleOfThree(int n)
    {
        var nString = n.ToString();

        for (int i = 0; i < nString.Length; i++)
        {
            var value = Convert.ToInt32(nString[..^i]);
            if (value % 3 == 0)
                return value;
        }
        return null;
    }
}
