namespace CodeWars.src;

public class LostNumberInNumberSequence
{
    public static int FindDeletedNumber(List<int> startingList, List<int> mixedList) =>
        startingList.Except(mixedList).FirstOrDefault();
}
