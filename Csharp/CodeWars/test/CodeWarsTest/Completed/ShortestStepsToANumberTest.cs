using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ShortestStepsToANumberTest
{
    [Test, Order(1)]
    public void SimpleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(1), Is.EqualTo(0));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(12), Is.EqualTo(4));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(16), Is.EqualTo(4));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(71), Is.EqualTo(9));
        }
    }

    [Test, Order(2)]
    public void SmallNumbers()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(2), Is.EqualTo(1));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(3), Is.EqualTo(2));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(4), Is.EqualTo(2));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(5), Is.EqualTo(3));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(6), Is.EqualTo(3));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(7), Is.EqualTo(4));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(8), Is.EqualTo(3));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(9), Is.EqualTo(4));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(10), Is.EqualTo(4));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(20), Is.EqualTo(5));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(30), Is.EqualTo(7));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(40), Is.EqualTo(6));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(50), Is.EqualTo(7));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(11), Is.EqualTo(5));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(24), Is.EqualTo(5));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(37), Is.EqualTo(7));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(48), Is.EqualTo(6));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(59), Is.EqualTo(9));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(65), Is.EqualTo(7));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(73), Is.EqualTo(8));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(83), Is.EqualTo(9));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(64), Is.EqualTo(6));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(99), Is.EqualTo(9));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(100), Is.EqualTo(8));
        }
    }

    [Test, Order(3)]
    public void BigNumbers()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(10000), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(1500), Is.EqualTo(16));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(1534), Is.EqualTo(18));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(1978), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(2763), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(9999), Is.EqualTo(20));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(2673), Is.EqualTo(16));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(4578), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(9876), Is.EqualTo(18));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(2659), Is.EqualTo(16));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(7777), Is.EqualTo(18));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(9364), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(7280), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(4998), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(9283), Is.EqualTo(17));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(8234), Is.EqualTo(16));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(7622), Is.EqualTo(19));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(800), Is.EqualTo(11));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(782), Is.EqualTo(13));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(674), Is.EqualTo(12));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(4467), Is.EqualTo(18));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(1233), Is.EqualTo(14));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(3678), Is.EqualTo(18));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(7892), Is.EqualTo(19));
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(5672), Is.EqualTo(16));
        }
    }

    [Test, Order(4)]
    public void SmallRandomNumbers()
    {
        Random rd = new();
        for (int i = 0; i < 50; i++)
        {
            int num = rd.Next(0, 1000);
            int expected = ExpectedMethod(num);
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(num), Is.EqualTo(expected));
        }
    }

    [Test, Order(5)]
    public void BigRandomNumbers()
    {
        Random rd = new();
        for (int i = 0; i < 50; i++)
        {
            int num = rd.Next(1000, 10000);
            int expected = ExpectedMethod(num);
            Assert.That(ShortestStepsToANumber.ShortestStepsToNum(num), Is.EqualTo(expected));
        }
    }

    private static int ExpectedMethod(int num)
    {
        int count = 0;
        while (num != 1)
        {
            if (num % 2 == 0)
                num /= 2;
            else
                num -= 1;
            count++;
        }
        return count;
    }
}