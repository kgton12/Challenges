namespace CodeWars.Resolutions;

public class PowerOf4Class
{
    public static bool PowerOf4(object? n)
    {
        if (n is null || n.GetType() != typeof(int))
            return false;

        int value = Convert.ToInt32(n);

        if (value % 1 != 0)
            return false;

        if (int.IsNegative(value))
            return false;

        for (int i = 0; Math.Pow(4, i) <= value; i++)
            if (Math.Pow(4, i) == value)
                return true;

        return false;
    }
}