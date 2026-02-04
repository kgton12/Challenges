using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ForUfcFansTotalBeginnersConorMcgregorVsGeorgeSaintPierreTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ForUFCFansTotalBeginnersConorMcGregorvsGeorgeSaintPierre.Quote("george saint pierre"), Is.EqualTo("I am not impressed by your performance."));
            Assert.That(ForUFCFansTotalBeginnersConorMcGregorvsGeorgeSaintPierre.Quote("conor mcgregor"), Is.EqualTo("I'd like to take this chance to apologize.. To absolutely NOBODY!"));
            Assert.That(ForUFCFansTotalBeginnersConorMcGregorvsGeorgeSaintPierre.Quote("George Saint Pierre"), Is.EqualTo("I am not impressed by your performance."));
            Assert.That(ForUFCFansTotalBeginnersConorMcGregorvsGeorgeSaintPierre.Quote("Conor McGregor"), Is.EqualTo("I'd like to take this chance to apologize.. To absolutely NOBODY!"));
        }
    }
}
