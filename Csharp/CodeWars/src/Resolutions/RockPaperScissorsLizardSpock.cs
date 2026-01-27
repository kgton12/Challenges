namespace CodeWars.Resolutions;

public class RockPaperScissorsLizardSpock
{
    public enum Value { Scissors, Paper, Rock, Lizard, Spock }
    public enum Ordering { LT, EQ, GT }

    private static readonly IEnumerable<Item> jokempo =
    [
        new() { Key = Value.Scissors, Value = Value.Paper },
        new() { Key = Value.Paper, Value = Value.Rock },
        new() { Key = Value.Rock, Value = Value.Lizard },
        new() { Key = Value.Lizard, Value = Value.Spock },
        new() { Key = Value.Spock, Value = Value.Scissors },
        new() { Key = Value.Scissors, Value = Value.Lizard },
        new() { Key = Value.Lizard, Value = Value.Paper },
        new() { Key = Value.Paper, Value = Value.Spock },
        new() { Key = Value.Spock, Value = Value.Rock },
        new() { Key = Value.Rock, Value = Value.Scissors }
    ];

    public static Ordering Rpsls(Value a, Value b)
    {
        if (jokempo.Where(x => x.Key == a && x.Value == b).Any())
            return Ordering.GT;
        else if (jokempo.Where(x => x.Key == b && x.Value == a).Any())
            return Ordering.LT;
        else
            return Ordering.EQ;
    }

    private class Item
    {
        public Value Key { get; set; }
        public Value Value { get; set; }
    }
}
