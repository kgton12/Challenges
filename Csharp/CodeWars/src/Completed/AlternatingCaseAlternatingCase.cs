namespace CodeWars.Completed;

public static class AlternatingCaseAlternatingCase
{
    public static string ToAlternatingCase(this string s) =>
        string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
}
