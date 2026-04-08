using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumOfTwoLowestPositiveIntegersTest
{
    [Test, Order(1)]
    public void Test1()
    {
        int[] numbers = [5, 8, 12, 19, 22];
        Assert.That(SumOfTwoLowestPositiveIntegers.SumTwoSmallestNumbers(numbers), Is.EqualTo(13));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] numbers = [19, 5, 42, 2, 77];
        Assert.That(SumOfTwoLowestPositiveIntegers.SumTwoSmallestNumbers(numbers), Is.EqualTo(7));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] numbers = [10, 343445353, 3453445, 2147483647];
        Assert.That(SumOfTwoLowestPositiveIntegers.SumTwoSmallestNumbers(numbers), Is.EqualTo(3453455));
    }
}
