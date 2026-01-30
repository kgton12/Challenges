using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class OrderedCountOfCharactersTest
{
    [Test]
    public void ExampleTests()
    {
        var expected1 = new List<Tuple<char, int>>() {
                Tuple('a', 5),
                Tuple('b', 2),
                Tuple('r', 2),
                Tuple('c', 1),
                Tuple('d', 1)
            };
        Assert.That(OrderedCountOfCharacters.OrderedCount("abracadabra"), Is.EqualTo(expected1));

        var expected2 = new List<Tuple<char, int>>() {
                Tuple('C', 1),
                Tuple('o', 1),
                Tuple('d', 1),
                Tuple('e', 1),
                Tuple(' ', 1),
                Tuple('W', 1),
                Tuple('a', 1),
                Tuple('r', 1),
                Tuple('s', 1)
            };
        Assert.That(OrderedCountOfCharacters.OrderedCount("Code Wars"), Is.EqualTo(expected2));
    }

    private static Tuple<char, int> Tuple(char character, int count)
    {
        return new Tuple<char, int>(character, count);
    }
}
