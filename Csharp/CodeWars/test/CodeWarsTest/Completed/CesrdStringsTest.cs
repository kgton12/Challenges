using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CesrdStringsTest
{
    [Test]
    public void SampleTests()
    {
        Assertion("This is very strange", ("*h*s *s v*ry *tr*ng*", "Tiiesae"));
        Assertion("AMAZING", ("A**Z*N*", "MAIG"));
        Assertion("xyz", ("xyz", ""));
        Assertion("", ("", ""));
        Assertion("abc", ("***", "abc"));
        Assertion("C Sharp", ("C*Sha*p", " r"));
    }

    private static void Assertion(string expected, (string, string) inputs) =>
      Assert.That(
        CesrdStrings.Uncensor(inputs.Item1, inputs.Item2),
        Is.EqualTo(expected),
        $"\n  Infected: \"{inputs.Item1}\"" +
        $"\n  Discovered: \"{inputs.Item2}\""
      );
}
