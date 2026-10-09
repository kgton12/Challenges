namespace CodeWars.Completed;

public class SortTheColumnsOfACsvFile
{
    public static string SortCsvColumns(string csvFileContent)
    {
        var lines = csvFileContent.Split('\n');

        int rowCount = lines.Length;
        if (lines[rowCount - 1].Length == 0)
            rowCount--;

        var headers = lines[0].TrimEnd('\n').Split(';');

        var columnOrder = Enumerable
            .Range(0, headers.Length)
            .OrderBy(i => headers[i], StringComparer.OrdinalIgnoreCase)
            .ToArray();

        for (int row = 0; row < rowCount; row++)
        {
            bool hasCarriageReturn = lines[row].EndsWith("\r", StringComparison.Ordinal);
            string line = hasCarriageReturn
                ? lines[row][..^1]
                : lines[row];

            var cells = line.Split(';');

            lines[row] = string.Join(
                ";",
                columnOrder.Select(i => cells[i])
            ) + (hasCarriageReturn ? "\r" : "");
        }

        return string.Join("\n", lines);
    }
}