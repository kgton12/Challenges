using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HammingDistanceTest
{
    [TestCase("hello world", "hello world", 0)]
    [TestCase("I like turtles", "I like turkeys", 3)]
    [TestCase("espresso", "Expresso", 2)]
    [TestCase("hello world", "hello tokyo", 4)]
    [TestCase("old father, old artificer", "of my soul the uncreated ", 24)]
    [TestCase("&'=LN)K&G?KIH(v,HBO4x3", "&'=LN)K4G?KIH(v,H6O4xW", 3)]
    public void StaticTests(string a, string b, int expected)
    {
        Assert.That(HammingDistance.Distance(a, b), Is.EqualTo(expected),
            string.Format("Expected hamming distance of '{0}' and '{1}' to be {2}", a, b, expected));
    }
}