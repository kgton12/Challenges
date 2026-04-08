namespace CodeWars.Completed;

public class AbbreviateaTwoWordName
{
    public static string AbbrevName(string name) =>
        string.Join(".",
            name
            .Split(" ")
            .Select(x => string.Concat(x.Take(1)).ToUpper())
         );
}
