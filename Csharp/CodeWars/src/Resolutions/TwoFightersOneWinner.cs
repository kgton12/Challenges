namespace CodeWars.Resolutions;

public class TwoFightersOneWinner
{
    public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        int quantityTurnForWinF1 = (int)Math.Ceiling((double)fighter2.Health / fighter1.DamagePerAttack);

        int quantityTurnForWinF2 = (int)Math.Ceiling((double)fighter1.Health / fighter2.DamagePerAttack);

        if (quantityTurnForWinF1 == quantityTurnForWinF2)
            return firstAttacker;

        return quantityTurnForWinF1 < quantityTurnForWinF2 ? fighter1.Name : fighter2.Name;
    }
}
public class Fighter(string name, int health, int damagePerAttack)
{
    public string Name = name;
    public int Health = health;
    public int DamagePerAttack = damagePerAttack;
}

