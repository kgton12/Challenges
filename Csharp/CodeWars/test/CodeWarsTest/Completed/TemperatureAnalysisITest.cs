using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TemperatureAnalysisITest
{
    [Test, Order(1)]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TemperatureAnalysisI.LowestTemperature("-1 50 -4 20 22 -7 0 10 -8"), Is.EqualTo(-8));
            Assert.That(TemperatureAnalysisI.LowestTemperature("10 50 12 20 22 13 20 100 18"), Is.EqualTo(10));
            Assert.That(TemperatureAnalysisI.LowestTemperature("-1 50 16 20 22 1 0 10 34"), Is.EqualTo(-1));
            Assert.That(TemperatureAnalysisI.LowestTemperature("-2 3 -1 12 45 14"), Is.EqualTo(-2));
            Assert.That(TemperatureAnalysisI.LowestTemperature(""), Is.Null);
        }
    }
}
