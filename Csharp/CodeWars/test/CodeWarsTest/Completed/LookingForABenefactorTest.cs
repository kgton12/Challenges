using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LookingForABenefactorTest
{
    private static void Testing(long actual, long expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(1)]
    public static void BasicTests()
    {
        double[] a = new double[] { 14, 30, 5, 7, 9, 11, 15 };
        Testing(LookingForABenefactor.NewAvg(a, 100), 709);
        a = new double[] { 14.0, 30.0, 5.0, 7.0, 9.0, 11.0, 16.0 };
        Testing(LookingForABenefactor.NewAvg(a, 90), 628);
    }

    [Test, Order(2)]
    public static void ErrorTests()
    {
        double[] a = new double[] { 14, 30, 5, 7, 9, 11, 15 };
        Assert.That(() => LookingForABenefactor.NewAvg(a, 2), Throws.ArgumentException);
    }
}
