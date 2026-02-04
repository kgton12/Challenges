using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HeadsAndLegsTest
{
    [Test, Order(1)]
    public void ValidNumberTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HeadsAndLegs.Animals(72, 200), Is.EqualTo(new int[] { 44, 28 }));
            Assert.That(HeadsAndLegs.Animals(116, 282), Is.EqualTo(new int[] { 91, 25 }));
            Assert.That(HeadsAndLegs.Animals(12, 24), Is.EqualTo(new int[] { 12, 0 }));
            Assert.That(HeadsAndLegs.Animals(6, 24), Is.EqualTo(new int[] { 0, 6 }));
            Assert.That(HeadsAndLegs.Animals(344, 872), Is.EqualTo(new int[] { 252, 92 }));
            Assert.That(HeadsAndLegs.Animals(158, 616), Is.EqualTo(new int[] { 8, 150 }));
        }
    }

    [Test, Order(2)]
    public void InvalidNumberTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HeadsAndLegs.Animals(25, 255), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(12, 25), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(54, 956), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(5455, 54956), Is.EqualTo("No solutions"));
        }
    }

    [Test, Order(3)]
    public void EdgeCasesTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HeadsAndLegs.Animals(0, 0), Is.EqualTo(new int[] { 0, 0 }));
            Assert.That(HeadsAndLegs.Animals(-1, -1), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(-45, 5), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(500, 0), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(0, 500), Is.EqualTo("No solutions"));
            Assert.That(HeadsAndLegs.Animals(5, -55), Is.EqualTo("No solutions"));
        }
    }
}
