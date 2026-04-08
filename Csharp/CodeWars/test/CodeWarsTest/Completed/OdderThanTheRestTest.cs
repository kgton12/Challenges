using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class OdderThanTheRestTest
{
    [Test, Description("Your solution should pass basic tests")]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(OdderThanTheRest.OddOne([2, 4, 6, 7, 10]), Is.EqualTo(3));
            Assert.That(OdderThanTheRest.OddOne([2, 16, 98, 10, 13, 78]), Is.EqualTo(4));
            Assert.That(OdderThanTheRest.OddOne([4, -8, 98, -12, -7, 90, 100]), Is.EqualTo(4));
            Assert.That(OdderThanTheRest.OddOne([2, 4, 6, 8]), Is.EqualTo(-1));
        }
    }
}
