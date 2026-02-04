using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ClassyClassesPersonTest
{
    [Test, Description("Should create a Person and have a getter for the Info property")]
    public void Test()
    {
        ClassyClassesPerson john = new("john", 34);
        string expectedInfo = "johns age is 34";
        Assert.That(john.Info, Is.EqualTo(expectedInfo));
    }
}
