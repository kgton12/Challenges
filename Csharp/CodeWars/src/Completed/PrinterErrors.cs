namespace CodeWars.Completed;

public class PrinterErrors
{
    public static string PrinterError(string s) =>
        $"{s.Where(x => x > 'm').Count()}/{s.Length}";
}
