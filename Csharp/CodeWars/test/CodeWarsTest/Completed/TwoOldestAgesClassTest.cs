using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TwoOldestAgesClassTest
{
    [Test, Order(1)]
    public void Test1()
    {
        int[] result = TwoOldestAgesClass.TwoOldestAges([1, 2, 10, 8]);
        Assert.That(result, Is.EqualTo([8, 10]));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] result = TwoOldestAgesClass.TwoOldestAges([1, 5, 87, 45, 8, 8]);
        Assert.That(result, Is.EqualTo([45, 87]));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] result = TwoOldestAgesClass.TwoOldestAges([6, 5, 83, 5, 3, 18]);
        Assert.That(result, Is.EqualTo([18, 83]));
    }

    [Test, Order(4)]
    public void Test4()
    {
        int[] result = TwoOldestAgesClass.TwoOldestAges([6, 5, 83, 83]);
        Assert.That(result, Is.EqualTo([83, 83]));
    }
}
