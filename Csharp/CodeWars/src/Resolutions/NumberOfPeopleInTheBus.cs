namespace CodeWars.src.Resolutions;

public class NumberOfPeopleInTheBus
{
    public static int Number(List<int[]> peopleListInOut) =>
        peopleListInOut.Sum(Item => Item[0] - Item[1]);
}
