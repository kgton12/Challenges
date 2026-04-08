using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FilterOutTheGeeseTest
{
    private static readonly string[] expected = ["Mallard", "Hook Bill", "Crested", "Blue Swedish"];
    private static readonly string[] expectedArray = ["Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested"];

    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FilterOutTheGeese.GooseFilter(["Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"]),
                    Is.EqualTo(expected));

            Assert.That(FilterOutTheGeese.GooseFilter(["Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested"]),
                Is.EqualTo(expectedArray));

            Assert.That(FilterOutTheGeese.GooseFilter(["African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"]),
                Is.EqualTo(Array.Empty<string>()));
        }
    }
}
