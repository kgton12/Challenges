using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CodewarsLeaderboardClimberTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CodewarsLeaderboardClimber.LeaderB("g964", 36097, 20000), Is.EqualTo("To beat g964's score, I must complete 5365 Beta kata and 2 8kyu kata. Dammit!"));
            Assert.That(CodewarsLeaderboardClimber.LeaderB("GiacomoSorbi", 23914, 23867), Is.EqualTo("To beat GiacomoSorbi's score, I must complete 15 Beta kata and 2 8kyu kata."));
            Assert.That(CodewarsLeaderboardClimber.LeaderB("ZozoFouchtra", 15991, 12000), Is.EqualTo("To beat ZozoFouchtra's score, I must complete 1330 Beta kata and 1 8kyu kata. Dammit!"));
            Assert.That(CodewarsLeaderboardClimber.LeaderB("ZozoFouchtra", 15991, 15991), Is.EqualTo("Only need one!"));
            Assert.That(CodewarsLeaderboardClimber.LeaderB("ZozoFouchtra", 15991, 15993), Is.EqualTo("Winning!"));
        }
    }
}
