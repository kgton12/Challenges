namespace CodeWars.Resolutions;

public class SimpleFun74GrowingPlant
{
    public static int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
    {
        int days = 0;
        int currentHeight = 0;

        while (currentHeight < DesiredHeight)
        {
            currentHeight += UpSpeed;
            if (currentHeight >= DesiredHeight)
            {
                days++;
                break;
            }

            currentHeight -= DownSpeed;
            days++;
        }

        return days;
    }
}
