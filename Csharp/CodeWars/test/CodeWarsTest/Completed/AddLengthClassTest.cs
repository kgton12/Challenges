using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AddLengthClassTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AddLengthClass.AddLength("apple ban"), Is.EqualTo(new string[] { "apple 5", "ban 3" }));
            Assert.That(AddLengthClass.AddLength("you will win"), Is.EqualTo(new string[] { "you 3", "will 4", "win 3" }));
        }
    }
}
