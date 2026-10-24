using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IsValidIdentifierTest
{
    [Test]
    public void TestValid()
    {
        Assert.That(IsValidIdentifier.IsValid("i1"), Is.True, "IsValid(\"i1\") should returns true");
    }

    [Test]
    public void TestInvalid()
    {
        Assert.That(IsValidIdentifier.IsValid("1i"), Is.False, "IsValid(\"1i\") should returns false");
    }
}
