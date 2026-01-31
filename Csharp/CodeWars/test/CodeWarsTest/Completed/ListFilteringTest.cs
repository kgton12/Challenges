using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ListFilteringTest
{
    [Test, Order(1)]
    public void GetIntegersFromList_MixedValues_ShouldPass_1()
    {
        var list = new List<object>() { 1, 2, "a", "b" };
        var expected = new List<int>() { 1, 2 };
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test, Order(2)]
    public void GetIntegersFromList_MixedValues_ShouldPass_2()
    {
        var list = new List<object>() { 1, "a", "b", 0, 15 };
        var expected = new List<int>() { 1, 0, 15 };
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test, Order(3)]
    public void GetIntegersFromList_MixedValues_ShouldPass_3()
    {
        var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
        var expected = new List<int>() { 1, 2, 123 };
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
