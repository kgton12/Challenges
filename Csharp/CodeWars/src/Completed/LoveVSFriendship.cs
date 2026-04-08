namespace CodeWars.Completed;

public class LoveVSFriendship
{
    public static int WordsToMarks(string str)
    {
        return str.Sum(letter => letter - 'a' + 1);
    }
}

