namespace CodeWars.Completed;

public static class TakeaTenMinutesWalk
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10) return false;

        int n = 0;
        int s = 0;
        int e = 0;
        int w = 0;

        foreach (var direction in walk)
        {
            if (direction == "n") n++;
            if (direction == "s") s++;
            if (direction == "e") e++;
            if (direction == "w") w++;
        }

        return n == s && e == w;
    }
}
