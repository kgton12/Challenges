using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class YouOnlyNeedOneBeginnerTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(YouOnlyNeedOneBeginner.Check([66, 101], 66), Is.True);
            Assert.That(YouOnlyNeedOneBeginner.Check([80, 117, 115, 104, 45, 85, 112, 115], 45), Is.True);

            Assert.That(YouOnlyNeedOneBeginner.Check(['t', 'e', 's', 't'], 'e'), Is.True);
            Assert.That(YouOnlyNeedOneBeginner.Check(["what", "a", "great", "kata"], "kat"), Is.False);
        }
    }
}
