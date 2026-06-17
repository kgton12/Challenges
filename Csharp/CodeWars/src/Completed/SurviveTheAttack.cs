namespace CodeWars.Completed;

public class SurviveTheAttack
{
    public static bool HasSurvived(int[] attackers, int[] defenders)
    {
        int score = 0;
        int maxLengthArray = Math.Max(attackers.Length, defenders.Length);

        Array.Resize(ref attackers, maxLengthArray);
        Array.Resize(ref defenders, maxLengthArray);

        for (int i = 0; i < maxLengthArray; i++)
        {
            if (attackers[i] > defenders[i])
                score--;
            else if (attackers[i] < defenders[i])
                score++;
        }

        if (score == 0)
            return defenders.Sum() == attackers.Sum() || defenders.Sum() > attackers.Sum();

        return score > 0;
    }
}