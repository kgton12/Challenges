namespace CodeWars.Completed;

public class OffloadYourWork
{
    public static string WorkNeeded(int projectMinutes, int[][] freelancers)
    {
        int totalFreelancerMinutes = freelancers.SelectMany(x => x.Select((y, i) => i == 0 ? y * 60 : y)).Sum();


        if (projectMinutes <= totalFreelancerMinutes)
            return "Easy Money!";
        else
        {
            int minutesNeeded = projectMinutes - totalFreelancerMinutes;
            int hours = minutesNeeded / 60;
            int minutes = minutesNeeded % 60;

            return $"I need to work {hours} hour(s) and {minutes} minute(s)";
        }
    }
}