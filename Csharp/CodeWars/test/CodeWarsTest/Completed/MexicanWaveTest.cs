using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MexicanWaveTest
{
    [TestCase]
    [Order(1)]
    public void BasicTest1()
    {
        List<string> result = ["Hello", "hEllo", "heLlo", "helLo", "hellO"];
        Assert.That(MexicanWave.Wave("hello"), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(2)]
    public void BasicTest2()
    {
        List<string> result = ["Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS"];
        Assert.That(MexicanWave.Wave("codewars"), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(3)]
    public void BasicTest3()
    {
        List<string> result = [];
        Assert.That(MexicanWave.Wave(""), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(4)]
    public void BasicTest4()
    {
        List<string> result = ["Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS"];
        Assert.That(MexicanWave.Wave("two words"), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(5)]
    public void BasicTest5()
    {
        List<string> result = [" Gap ", " gAp ", " gaP "];
        Assert.That(MexicanWave.Wave(" gap "), Is.EqualTo(result), "it should return '" + result + "'");
    }
}