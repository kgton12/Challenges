using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConsecutiveDigitsToFormSumTest
{
    [Test, Order(1)]
    public void SmallValues()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(9), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(69), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(8), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(57), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(6), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(13), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(16), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(91), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(75), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(38), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(25), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(32), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(65), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(13), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(16), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(99), Is.True);
        }
    }

    [Test, Order(2)]
    public void MediumValues()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(522), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(974), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(755), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(512), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(739), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(1006), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(838), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(1092), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(727), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(648), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(1024), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(851), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(541), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(1011), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(822), Is.True);
        }
    }

    [Test, Order(3)]
    public void LargeValues()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(382131), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(118070), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(17209), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(32768), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(161997), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(400779), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(198331), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(325482), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(88441), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(648), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(65536), Is.False);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(323744), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(183540), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(65271), Is.True);
            Assert.That(ConsecutiveDigitsToFormSum.ConsecutiveDucks(5263987), Is.True);
        }
    }
}
