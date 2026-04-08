using CodeWars.Completed;
using static CodeWars.Completed.AnimalSorter;

namespace CodeWarsTest.Completed;

public class SortMyAnimalsAdditionalTests
{
    [Test]
    public void Sort_EmptyList_ReturnsEmpty()
    {
        var animals = new List<Animal>();
        var output = new AnimalSorter().Sort(animals);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(output, Is.Not.Null);
            Assert.That(output, Is.Empty);
        }
    }

    [Test]
    public void Sort_OrderByNumberOfLegs_Ascending()
    {
        var animals = new List<Animal>
        {
            new() { Name = "X", NumberOfLegs = 3 },
            new() { Name = "Y", NumberOfLegs = 1 },
            new() { Name = "Z", NumberOfLegs = 2 },
            new() { Name = "W", NumberOfLegs = 1 }
        };

        var output = new AnimalSorter().Sort(animals);
        var legs = output.Select(a => a.NumberOfLegs).ToList();

        Assert.That(legs, Is.Ordered);
    }
}