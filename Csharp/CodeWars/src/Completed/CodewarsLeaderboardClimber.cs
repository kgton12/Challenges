namespace CodeWars.Completed;

public class CodewarsLeaderboardClimber
{
    public static string LeaderB(string user, int user_score, int your_score)
    {
        if (your_score > user_score)
            return "Winning!";

        if (your_score == user_score)
            return "Only need one!";

        int scoreDifference = user_score - your_score;
        int scoreBeta = scoreDifference / 3;
        int scoreKyu8 = (scoreDifference - (scoreBeta * 3));

        return $"To beat {user}'s score, I must complete {scoreBeta} Beta kata and {scoreKyu8} 8kyu kata." + (scoreBeta + scoreKyu8 > 1000 ? " Dammit!" : "");
    }
}