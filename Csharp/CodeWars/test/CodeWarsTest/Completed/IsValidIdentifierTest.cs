using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsValidIdentifierTest
{
    [Test, Order(1)]
    public void TestValid()
    {
        Assert.That(IsValidIdentifier.IsValid("i1"), Is.True, "IsValid(\"i1\") should returns true");
    }

    [Test, Order(2)]
    public void TestInvalid()
    {
        Assert.That(IsValidIdentifier.IsValid("1i"), Is.False, "IsValid(\"1i\") should returns false");
    }
}
