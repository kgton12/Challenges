using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ABTest
{
    [Test]
    public void TestSum()
    {
        byte a = 1;
        byte b = 2;
        Assert.That(AB.Sum(a, b), Is.EqualTo(3));
        
    }
}
