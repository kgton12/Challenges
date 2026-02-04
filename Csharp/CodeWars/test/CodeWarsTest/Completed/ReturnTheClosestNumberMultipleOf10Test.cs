using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReturnTheClosestNumberMultipleOf10Test
{
    [Test, Order(1)]
    public void _0_ShouldReturn10ForNumbersFrom10To14()
    {
        for (int i = 10; i <= 14; ++i)
        {
            Assert.That(ReturnTheClosestNumberMultipleOf10.ClosestMultiple10(i), Is.EqualTo(10));
        }
    }

    [Test, Order(2)]
    public void _1_ShouldReturn20ForNumbersFrom15To20()
    {
        for (int i = 15; i <= 20; ++i)
        {
            Assert.That(ReturnTheClosestNumberMultipleOf10.ClosestMultiple10(i), Is.EqualTo(20));
        }
    }
}
