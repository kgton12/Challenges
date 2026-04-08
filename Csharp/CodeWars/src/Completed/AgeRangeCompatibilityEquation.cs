namespace CodeWars.Completed;

public class AgeRangeCompatibilityEquation
{
    public static string DatingRange(int age)
    {
        int minAge, maxAge;

        if (age <= 14)
        {
            minAge = (int)Math.Floor(age - 0.10 * age);
            maxAge = (int)Math.Floor(age + 0.10 * age);
        }
        else
        {
            minAge = (int)Math.Floor(age / 2 + 7.0);
            maxAge = (int)Math.Floor((age - 7.0) * 2);
        }

        return $"{minAge}-{maxAge}";
    }
}
