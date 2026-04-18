using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TheLazyStartupOfficeTest
{
    [Test]
    public void ExampleTests()
    {
        var testInput = new string[][] { ["Bob", "Nora"], ["Ruby", "Carl"] };
        Assert.That(TheLazyStartupOffice.BinRota(testInput), Is.EqualTo(["Bob", "Nora", "Carl", "Ruby"]));

        var testInput1 = new string[][] { ["Billy"] };
        Assert.That(TheLazyStartupOffice.BinRota(testInput1), Is.EqualTo(["Billy"]));

        var testInput2 = new string[][] { ["Billy", "Nancy"] };
        Assert.That(TheLazyStartupOffice.BinRota(testInput2), Is.EqualTo(["Billy", "Nancy"]));

        var testInput3 = new string[][] { ["Billy"], ["Megan"], ["Aki"], ["Arun"], ["Joy"] };
        Assert.That(TheLazyStartupOffice.BinRota(testInput3), Is.EqualTo(["Billy", "Megan", "Aki", "Arun", "Joy"]));

        var testInput4 = new string[][] { ["Sam", "Nina", "Tim", "Helen", "Gurpreet", "Edward", "Holly", "Eliza"], ["Billy", "Megan", "Aki", "Arun", "Joy", "Anish", "Lee", "Maryan"], ["Nick", "Josh", "Pete", "Kavita", "Daisy", "Francesca", "Alfie", "Macy"] };
        Assert.That(TheLazyStartupOffice.BinRota(testInput4), Is.EqualTo(["Sam", "Nina", "Tim", "Helen", "Gurpreet", "Edward", "Holly", "Eliza", "Maryan", "Lee", "Anish", "Joy", "Arun", "Aki", "Megan", "Billy", "Nick", "Josh", "Pete", "Kavita", "Daisy", "Francesca", "Alfie", "Macy"]));

        var testInput5 = new string[][] { ["Stefan", "Raj", "Marie"], ["Alexa", "Amy", "Edward"], ["Liz", "Claire", "Juan"], ["Dee", "Luke", "Elle"] };
        Assert.That(TheLazyStartupOffice.BinRota(testInput5), Is.EqualTo(["Stefan", "Raj", "Marie", "Edward", "Amy", "Alexa", "Liz", "Claire", "Juan", "Elle", "Luke", "Dee"]));
    }
}