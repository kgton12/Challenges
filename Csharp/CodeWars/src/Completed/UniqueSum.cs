namespace CodeWars.Completed;

public class UniqueSumClass
{
    public static int? UniqueSum(List<int> lst) =>
       lst.Count == 0 || lst is null
        ? null
        : lst.Distinct().Sum();
}
