using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class ComputeUnixPath
{
    public static String CombinePathsUri(params String[] PathParts)
    {
        string patch = string.Join(' ', PathParts);
        List<char> invalidChars = ['\\', '/'];

        invalidChars.AddRange(Path.GetInvalidPathChars());
        string regexInvalidChars = Regex.Escape(new string([.. invalidChars]));

        patch = Regex.Replace(patch, $"[{regexInvalidChars}]", " ");

        string[] strArrPathHygienized = patch.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        return "/" +
                Regex.Replace(string.Join('/', strArrPathHygienized), @"/{2,}", "/");
    }
}
