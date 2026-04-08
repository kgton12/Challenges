namespace CodeWars.Completed;

public class AllOrNothing
{
    public static bool PossiblyPerfect(string[] key, string[] ans)
    {
        int correctAwser = 0;
        int incorrectAwser = 0;

        for (int i = 0; i < key.Length; i++)
        {
            if (key[i] == "_") continue;

            if (key[i] == ans[i])
                correctAwser++;
            else
                incorrectAwser++;
        }

        return correctAwser == 0 || incorrectAwser == 0;
    }
}
