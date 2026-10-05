using CodeWars.Completed;
using System.Text.RegularExpressions;

namespace CodeWarsTest.Completed;

public class MissingAlphabetTest
{
    [Test, Order(1)]
    public void TestingFirstOccurances()
    {
        Assert.That(MissingAlphabet.InsertMissingLetters("hellllllllllllooooo"), Is.EqualTo("hIJKMNPQRSTUVWXYZeFGIJKMNPQRSTUVWXYZlMNPQRSTUVWXYZllllllllllloPQRSTUVWXYZoooo"), "missing alphabet should be inserted only after the first occurrence of a letter");
    }

    [Test, Order(2)]
    public void TestingEvenOccurances()
    {
        Assert.That(MissingAlphabet.InsertMissingLetters("pixxa"), Is.EqualTo("pQRSTUVWYZiJKLMNOQRSTUVWYZxYZxaBCDEFGHJKLMNOQRSTUVWYZ"));
    }

    [Test, Order(3)]
    public void TestingOddOccurances()
    {
        Assert.That(MissingAlphabet.InsertMissingLetters("xpixax"), Is.EqualTo("xYZpQRSTUVWYZiJKLMNOQRSTUVWYZxaBCDEFGHJKLMNOQRSTUVWYZx"));
    }

    [Test, Order(4)]
    public void TestingLastCharInAlphabet()
    {
        Assert.That(MissingAlphabet.InsertMissingLetters("z"), Is.EqualTo("z"), "The alphabet ends here, you cannot add any letter after this character");
    }

    [Test, Order(5)]
    public void TestingCompleteAlphabet()
    {
        Assert.That(MissingAlphabet.InsertMissingLetters("abcdefghijklmnopqrstuvwxyz"), Is.EqualTo("abcdefghijklmnopqrstuvwxyz"), "an string containing all the letters should return the alphabet");
    }

    [Test, Order(6)]
    public void RandomTests()
    {
        for (int i = 0; i < 100; i++)
        {
            string str = MakeString();
            string expected = Solution(str);
            string actual = MissingAlphabet.InsertMissingLetters(str);

            Console.WriteLine($"Passed: {str}\nYour result: {actual}\nExpected result: {expected}");
            Console.WriteLine();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    private Random rand = new Random();

    private string MakeString()
    {
        return string.Join("", Enumerable
            .Range(0, rand.Next(51))
            .Select(x => "abcdefghijklmnopqrstuvwxyz"[rand.Next(26)]));
    }

    private static string Solution(string str)
    {
        return string.Join("", str
            .Select((x, i) => x + new Regex("[" + str + "]").Replace(string.Join("", Enumerable.Range(0, 122 - x)
                .Select(y => ((char)(str.IndexOf(x) != i ? x : str[i] + y + 1)).ToString())), "")
                .ToUpper()));
    }
}