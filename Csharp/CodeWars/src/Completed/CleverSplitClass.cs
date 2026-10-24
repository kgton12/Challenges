namespace CodeWars.Completed;

public class CleverSplitClass
{
    public static string[] CleverSplit(string s)
    {
        List<string> result = [];
        string auxWord = "";
        bool isOpen = false;

        foreach (var chr in s)
        {
            if (chr == ' ' && !isOpen)//split
            {
                AddValue(auxWord, result);

                auxWord = "";
            }
            else if (chr == '[')//open brackets
            {
                AddValue(auxWord, result);

                auxWord = "";
                auxWord += chr;
                isOpen = !isOpen;
            }
            else if (chr == ']')//close brackets
            {
                auxWord += chr;

                AddValue(auxWord, result);

                auxWord = "";
                isOpen = !isOpen;
            }
            else
                auxWord += chr;
        }
        AddValue(auxWord, result);


        return [.. result];
    }

    private static void AddValue(string auxWord, List<string> result)
    {
        if (!string.IsNullOrEmpty(auxWord))
            result.Add(auxWord);
    }
}