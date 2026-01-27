namespace CodeWars.Resolutions;

public static class FormattingDecimalPlaces1
{
    public static double TwoDecimalPlaces(double number) =>
        Math.Truncate(number * 100.0) / 100.0;
}

