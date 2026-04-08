namespace CodeWars.Completed;

public class CorrectTheDateString
{
    public static string? Correct(string? dateString)
    {
        if (string.IsNullOrEmpty(dateString))
            return dateString;

        var parts = dateString.Split('.');

        if (parts.Length != 3)
            return null;

        if (!int.TryParse(parts[0], out int day) ||
            !int.TryParse(parts[1], out int month) ||
            !int.TryParse(parts[2], out int year))
            return null;

        DateOnly corrected = new DateOnly(1, 1, 1)
            .AddYears(year - 1)
            .AddMonths(month - 1)
            .AddDays(day - 1);

        return corrected.ToString("dd.MM.yyyy");
    }
}