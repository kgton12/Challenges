using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class InitializeMyNameTest
{
    [Test, Description("Only first name")]
    public void OnlyFirstName()
    {
        Assert.That(InitializeMyName.InitializeNames("Dimitri"), Is.EqualTo("Dimitri"));
    }

    [Test, Description("No middle name")]
    public void NoMiddleName()
    {
        Assert.That(InitializeMyName.InitializeNames("Jack Ryan"), Is.EqualTo("Jack Ryan"));
    }

    [Test, Description("One middle name")]
    public void OneMiddleName()
    {
        Assert.That(InitializeMyName.InitializeNames("Lois Mary Lane"), Is.EqualTo("Lois M. Lane"));
    }

    [Test, Description("More middle names")]
    public void MoreMiddleNames()
    {
        Assert.That(InitializeMyName.InitializeNames("Alice Betty Catherine Davis"), Is.EqualTo("Alice B. C. Davis"));
    }
}
