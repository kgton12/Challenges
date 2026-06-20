using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumConsecutivesClassTest
{
    [Test]
    public static void Test1()
    {
        List<int> i = [1, 4, 4, 4, 0, 4, 3, 3, 1];
        List<int> o = [1, 12, 0, 4, 6, 1];
        Console.WriteLine("Input: {1,4,4,4,0,4,3,3,1}");
        Assert.That(SumConsecutivesClass.SumConsecutives(i), Is.EqualTo(o));

        i = [-5, -5, 7, 7, 12, 0];
        o = [-10, 14, 12, 0];
        Console.WriteLine("Input: {-5,-5,7,7,12,0}");
        Assert.That(SumConsecutivesClass.SumConsecutives(i), Is.EqualTo(o));

        i = [1, 1, 2, 3, 4, 4];
        o = [2, 2, 3, 8];
        Console.WriteLine("Input: {1, 1, 2, 3, 4, 4}");
        Assert.That(SumConsecutivesClass.SumConsecutives(i), Is.EqualTo(o));
    }
}