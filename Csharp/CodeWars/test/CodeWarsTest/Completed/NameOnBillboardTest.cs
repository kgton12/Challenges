using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NameOnBillboardTest
{
    [Test]
    public void SampleTests()
    {
        Assertion(600, "Jeong-Ho Aristotelis");
        Assertion(40, "CODEWARS", 5);
    }

    private static void Assertion(double expected, string name, double price = -1)
    {
        double actual = price == -1 ? NameOnBillboard.Billboard(name) : NameOnBillboard.Billboard(name, price);
        Assert.That(actual, Is.EqualTo(expected).Within(0.000001),
          $"\n  Name: \"{name}\"\n" +
          $"  Price: {(price == -1 ? 30 : price)}\n\n");
    }
}
