namespace CodeWars.Completed;

public class LoneliestCharacter
{
    public static char[] Loneliest(string result)
    {
        Dictionary<char, int> dic = [];
        result = result.Trim();

        for (int index = 0; index < result.Length; index++)
        {
            if (result[index] != ' ')
            {
                int spacesLeft = SpacesInLeft(index, result);
                int spacesRight = SpacesInRigth(index, result);

                dic.Add(result[index], spacesRight + spacesLeft);
            }
        }

        int maxSpaces = dic.OrderByDescending(x => x.Value).FirstOrDefault().Value;

        return [.. dic.Where(x => x.Value == maxSpaces).Select(x => x.Key)];
    }

    private static int SpacesInLeft(int index, string str)
    {
        int result = 0;
        for (int i = index - 1; i > 0; i--)
        {
            if (str[i] == ' ')
                result++;
            else
                break;
        }

        return result;
    }

    private static int SpacesInRigth(int index, string str)
    {
        int result = 0;
        for (int i = index + 1; i < str.Length; i++)
        {
            if (str[i] == ' ')
                result++;
            else
                break;
        }

        return result;
    }
}
