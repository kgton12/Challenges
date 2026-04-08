using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CalculateTwoPeoplesIndividualAgesTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CalculateTwoPeoplesIndividualAges.GetAges(24, 4), Is.EqualTo(new double[] { 14, 10 }), "it returns {14, 10} when passed 24, 4");
            Assert.That(CalculateTwoPeoplesIndividualAges.GetAges(63, 14), Is.EqualTo([38.5, 24.5]), "it returns {38.5, 24.5} when passed 63, 14");
            Assert.That(CalculateTwoPeoplesIndividualAges.GetAges(63, -14), Is.Null, "it returns null when passed 63, -14");
        }
    }
}
