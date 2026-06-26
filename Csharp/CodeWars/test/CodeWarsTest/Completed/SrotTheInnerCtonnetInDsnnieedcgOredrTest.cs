using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SrotTheInnerCtonnetInDsnnieedcgOredrTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SrotTheInnerCtonnetInDsnnieedcgOredr.SortTheInnerContent("sort the inner content in descending order"), Is.EqualTo("srot the inner ctonnet in dsnnieedcg oredr"));
            Assert.That(SrotTheInnerCtonnetInDsnnieedcgOredr.SortTheInnerContent("wait for me"), Is.EqualTo("wiat for me"));
            Assert.That(SrotTheInnerCtonnetInDsnnieedcgOredr.SortTheInnerContent("this kata is easy"), Is.EqualTo("tihs ktaa is esay"));
        }
    }
}
