namespace CodeWars.Completed;

public class NaughtyOrNice
{
    public static IEnumerable<string> GetNiceNames(IEnumerable<NaughtyOrNicePerson> people) =>
        people.Where(x => x.WasNice).Select(x => x.Name);

    public static IEnumerable<string> GetNaughtyNames(IEnumerable<NaughtyOrNicePerson> people) =>
        people.Where(x => !x.WasNice).Select(x => x.Name);
}
public class NaughtyOrNicePerson()
{
    public string Name { get; set; } = string.Empty;
    public bool WasNice { get; set; }
}