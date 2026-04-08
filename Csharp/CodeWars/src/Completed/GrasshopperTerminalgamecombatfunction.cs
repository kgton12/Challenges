namespace CodeWars.Completed;

public class GrasshopperTerminalgamecombatfunction
{
    public static float Combat(float health, float damage)
    {
        float result = health - damage;
        return result <= 0 ? 0 : result;
    }
}

