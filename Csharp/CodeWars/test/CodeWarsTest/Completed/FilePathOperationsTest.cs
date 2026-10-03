using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class FilePathOperationsTest
{
    [Test]
    public void ExampleTest()
    {
        FilePathOperations FM = new("/Users/person1/Pictures/house.png");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FM.Extension(), Is.EqualTo("png"));
            Assert.That(FM.Filename(), Is.EqualTo("house"));
            Assert.That(FM.Dirpath(), Is.EqualTo("/Users/person1/Pictures/"));
        }
    }
}
