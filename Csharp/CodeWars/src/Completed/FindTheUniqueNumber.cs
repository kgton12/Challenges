namespace CodeWars.Completed;

public class FindTheUniqueNumber
{
    public static int GetUnique(IEnumerable<int> numbers) =>
        numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
}
