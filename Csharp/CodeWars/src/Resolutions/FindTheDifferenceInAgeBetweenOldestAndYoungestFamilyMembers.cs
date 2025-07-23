namespace CodeWars.src.Resolutions;

public class FindTheDifferenceInAgeBetweenOldestAndYoungestFamilyMembers
{
    public static int[] DifferenceInAges(int[] ages) =>
        [ages.Min(), ages.Max(), ages.Max() - ages.Min()];
}
