namespace CodeWars.Completed;

public class WillThereBeEnoughSpace
{
    public static int Enough(int cap, int on, int wait)
    {
        int onWait = on + wait;

        return cap >= onWait ? 0 : onWait - cap;
    }
}
