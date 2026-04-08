using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MultiplicationTableClassTest
{
    [Test]
    public void MyTest()
    {
        int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
        Assert.That(MultiplicationTableClass.MultiplicationTable(3), Is.EqualTo(expected));
    }
}
