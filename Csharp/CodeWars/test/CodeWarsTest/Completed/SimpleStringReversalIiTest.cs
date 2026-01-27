using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleStringReversalIiTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleStringReversalIi.Solve("codewars", 1, 5), Is.EqualTo("cawedors"));
            Assert.That(SimpleStringReversalIi.Solve("codingIsFun", 2, 100), Is.EqualTo("conuFsIgnid"));
            Assert.That(SimpleStringReversalIi.Solve("FunctionalProgramming", 2, 15), Is.EqualTo("FuargorPlanoitcnmming"));
            Assert.That(SimpleStringReversalIi.Solve("abcefghijklmnopqrstuvwxyz", 0, 20), Is.EqualTo("vutsrqponmlkjihgfecbawxyz"));
            Assert.That(SimpleStringReversalIi.Solve("abcefghijklmnopqrstuvwxyz", 5, 20), Is.EqualTo("abcefvutsrqponmlkjihgwxyz"));
        }

    }
}
