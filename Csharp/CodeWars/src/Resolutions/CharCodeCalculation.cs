namespace CodeWars.Resolutions;

public class CharCodeCalculation
{
    public static int Calc(string str)
    {
        string total1 = string.Concat(str.Select(c => ((int)c).ToString()));

        string total2 = total1.Replace('7', '1');

        int sumTotal1 = total1.Sum(c => int.Parse(c.ToString()));
        int sumTotal2 = total2.Sum(c => int.Parse(c.ToString()));

        return sumTotal1 - sumTotal2;
    }
}
