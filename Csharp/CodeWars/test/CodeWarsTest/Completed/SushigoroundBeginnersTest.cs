using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SushigoroundBeginnersTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SushigoroundBeginners.TotalBill("rr"), Is.EqualTo(4));
            Assert.That(SushigoroundBeginners.TotalBill("rr rrr"), Is.EqualTo(8));
            Assert.That(SushigoroundBeginners.TotalBill("rr rrr rrr rr"), Is.EqualTo(16));
            Assert.That(SushigoroundBeginners.TotalBill("rrrrrrrrrrrrrrrrrr   rr r"), Is.EqualTo(34));
            Assert.That(SushigoroundBeginners.TotalBill(""), Is.Zero);
        }
    }
}
