namespace CodeWars.Completed;

public static class DoIGetABonus
{
    public static string BonusTime(int salary, bool bonus) =>
        $"${(bonus ? salary * 10 : salary)}";
}
