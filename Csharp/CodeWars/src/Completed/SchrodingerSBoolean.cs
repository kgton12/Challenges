namespace CodeWars.Completed;

public class SchrodingerSBoolean
{
    public static AlwaysTrue? omnibool;

    public class AlwaysTrue
    {
        public static bool operator ==(AlwaysTrue first, bool second)
        {
            return true;
        }
        public static bool operator !=(AlwaysTrue first, bool second)
        {
            return true;
        }
    }
}