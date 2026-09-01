using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MillipedeOfWordsTest
{
    private static void Testing(bool actual, bool expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(1)]
    public static void ExampleTestTrue()
    {
        Testing(MillipedeOfWords.Millipede(["excavate", "endure", "screen", "desire", "theater", "excess", "night"]), true);
    }

    [Test, Order(2)]
    public static void ExampleTestFalse()
    {
        Testing(MillipedeOfWords.Millipede(["trade", "pole", "view", "grave", "ladder", "mushroom", "president"]), false);
    }

    [Test, Order(3)]
    public static void FiveWordsTrue()
    {
        Testing(MillipedeOfWords.Millipede(["screen", "desire", "theater", "excess", "night"]), true);
    }

    [Test, Order(4)]
    public static void FourWordsFalse()
    {
        Testing(MillipedeOfWords.Millipede(["trade", "pole", "view", "grave"]), false);
    }

    [Test, Order(5)]
    public static void TestsAreNotBroken()
    {
        Testing(MillipedeOfWords.Millipede(["excavate", "east", "strike", "transport"]), true);
    }

    [Test, Order(6)]
    public static void OneLetterWordsFalse()
    {
        Testing(MillipedeOfWords.Millipede(["a", "b", "v", "z", "x", "r", "e"]), false);
    }

    [Test, Order(7)]
    public static void OneLetterWordsTrue()
    {
        Testing(MillipedeOfWords.Millipede(["east", "e", "e", "t", "t", "e", "time"]), true);
    }
}
