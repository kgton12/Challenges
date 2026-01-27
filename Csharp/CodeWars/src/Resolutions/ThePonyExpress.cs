namespace CodeWars.Resolutions;

public class ThePonyExpress
{
    public static int Riders(int[] stations) =>
        stations.Aggregate(
            (riders: 1, distance: 0),
            (acc, station) =>
                acc.distance + station > 100
                    ? (acc.riders + 1, station)
                    : (acc.riders, acc.distance + station)
        ).riders;
}
