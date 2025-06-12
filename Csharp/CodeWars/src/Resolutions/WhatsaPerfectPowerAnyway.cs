namespace CodeWars.src.Resolutions;

public class WhatsaPerfectPowerAnyway
{
    public static (int, int)? IsPerfectPower(int n)
    {
        if (n <= 1)
            return null;

        int maxExponent = (int)Math.Log(n, 2) + 1;

        for (int k = 2; k <= maxExponent; k++)
        {
            double mCandidate = Math.Pow(n, 1.0 / k);
            int m = (int)Math.Round(mCandidate);

            if (Math.Pow(m, k) == n)
                return (m, k);
        }

        return null;
    }
}
