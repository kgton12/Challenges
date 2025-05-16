namespace CodeWars.src.Resolutions;

public class LoveVSFriendship
{
    public static int WordsToMarks(string str)
    {
        return str.Sum(letter => letter - 'a' + 1);
    }
}

