using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NaughtyOrNiceTest
{
    [Test]
    public void NaughtyTest()
    {
        var naughty = new List<NaughtyOrNicePerson> {
          new() { Name = "Marco", WasNice =  false},
          new() { Name = "Luc", WasNice =  false},
    };
        var nice = new List<NaughtyOrNicePerson> {
          new() { Name = "Ryan", WasNice =  true},
          new() { Name = "Barak", WasNice =  true},
    };

        var both = naughty.Concat(nice);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(NaughtyOrNice.GetNiceNames(naughty).Count(), Is.Zero, "Wrong number of nice names");
            Assert.That(NaughtyOrNice.GetNaughtyNames(nice).Count(), Is.Zero, "Wrong number of naughty names");
            Assert.That(string.Join(",", NaughtyOrNice.GetNiceNames(nice)), Is.EqualTo("Ryan,Barak"));
            Assert.That(string.Join(",", NaughtyOrNice.GetNaughtyNames(naughty)), Is.EqualTo("Marco,Luc"));
            Assert.That(string.Join(",", NaughtyOrNice.GetNiceNames(both)), Is.EqualTo("Ryan,Barak"));
            Assert.That(string.Join(",", NaughtyOrNice.GetNaughtyNames(both)), Is.EqualTo("Marco,Luc"));
        }
    }
}
