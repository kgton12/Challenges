namespace CodeWars.Completed;

public class FriendorFoe
{
    public static IEnumerable<string> FriendOrFoe(string[] names) =>
        names.Where(x => x.Length == 4);
}
