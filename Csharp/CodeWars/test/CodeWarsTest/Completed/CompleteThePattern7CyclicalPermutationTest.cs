using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompleteThePattern7CyclicalPermutationTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompleteThePattern7CyclicalPermutation.Pattern(7), Is.EqualTo("1234567\n2345671\n3456712\n4567123\n5671234\n6712345\n7123456"));
            Assert.That(CompleteThePattern7CyclicalPermutation.Pattern(1), Is.EqualTo("1"));
            Assert.That(CompleteThePattern7CyclicalPermutation.Pattern(4), Is.EqualTo("1234\n2341\n3412\n4123"));
            Assert.That(CompleteThePattern7CyclicalPermutation.Pattern(0), Is.EqualTo(""));
            Assert.That(CompleteThePattern7CyclicalPermutation.Pattern(-25), Is.EqualTo(""));
        }
    }
}
