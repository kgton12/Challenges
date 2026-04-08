namespace CodeWars.Completed;

public class WhatsTheRealFloor
{
    public static int GetRealFloor(int n) =>
        n switch
        {
            < 1 => n,
            < 13 => n - 1,
            _ => n - 2
        };

}
