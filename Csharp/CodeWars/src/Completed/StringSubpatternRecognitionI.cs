namespace CodeWars.Completed;

public class StringSubpatternRecognitionI
{
    public static bool HasSubpattern(string str)
    {
        List<string> prefixList = [];
        double strLength = Convert.ToDouble(str.Length);

        for (int i = 1; i < (str.Length / 2) + 1; i++)
        {
            string aux = str[0..i];
            if (double.IsInteger(strLength / aux.Length))
                prefixList.Add(aux);
        }

        foreach (var item in prefixList)
        {
            if (str.Replace(item, "").Length == 0)
                return true;
        }

        return false;
    }
}