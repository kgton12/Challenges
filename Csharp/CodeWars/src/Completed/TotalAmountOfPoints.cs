namespace CodeWars.Completed;

public class TotalAmountOfPoints
{
    public static int TotalPoints(string[] games) =>
        games.Sum(x =>
        {
            var score = x.Split(':').Select(x => Convert.ToInt32(x)).ToArray();

            if (score[0] > score[1])
                return 3;
            else if (score[0] == score[1])
                return 1;

            return 0;
        });
}
