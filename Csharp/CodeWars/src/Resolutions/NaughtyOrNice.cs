namespace CodeWars.src.Resolutions;

public class NaughtyOrNice
{
    public class Person()
    {
        public string Name { get; set; } = string.Empty;
        public bool WasNice { get; set; }
    }

    public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people) =>
        people.Where(x => x.WasNice).Select(x => x.Name);

    public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people) =>
        people.Where(x => !x.WasNice).Select(x => x.Name);
}
