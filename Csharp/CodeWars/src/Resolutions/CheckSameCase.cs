namespace CodeWars.Resolutions;

public class CheckSameCase
{
    public static int SameCase(char a, char b)
    {
        if (char.IsUpper(a) == char.IsUpper(b) && char.IsLetter(a) && char.IsLetter(b))
            return 1;
        else if (char.IsLetter(a) && char.IsLetter(b) && char.IsUpper(a) != char.IsUpper(b))
            return 0;

        return -1;
    }
}
