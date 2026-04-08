using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class OnesAndZerosTest
{
    private readonly int[] Test1 = [0, 0, 0, 0];
    private readonly int[] Test2 = [1, 1, 1, 1];
    private readonly int[] Test3 = [0, 1, 1, 0];
    private readonly int[] Test4 = [0, 1, 0, 1];
    [Test]
    public void BasicTesting()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(OnesAndZeros.BinaryArrayToNumber(Test1), Is.Zero);
            Assert.That(OnesAndZeros.BinaryArrayToNumber(Test2), Is.EqualTo(15));
            Assert.That(OnesAndZeros.BinaryArrayToNumber(Test3), Is.EqualTo(6));
            Assert.That(OnesAndZeros.BinaryArrayToNumber(Test4), Is.EqualTo(5));
        }
    }
}
