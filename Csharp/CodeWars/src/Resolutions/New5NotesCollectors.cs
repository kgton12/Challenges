namespace CodeWars.Resolutions;

public class New5NotesCollectors
{
    public static int GetNewNotes(int salary, int[] bills) =>
        bills.Sum() < salary ?
        (salary - bills.Sum()) / 5
        : 0;
}
