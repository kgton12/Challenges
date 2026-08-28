using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BingoCardTest
{
    [Test, Order(1)]
    public void CardHas24Numbers()
    {
        Assert.That(BingoCard.GetCard(), Has.Length.EqualTo(24));
    }

    [Test, Order(2)]
    public void EachNumberOnCardIsUnique()
    {
        var card = BingoCard.GetCard();
        Assert.That(card, Has.Length.EqualTo(card.ToList().Distinct().Count()));
    }

    [Order(3)]
    [TestCase("B", 5)]
    [TestCase("I", 5)]
    [TestCase("N", 4)]
    [TestCase("G", 5)]
    [TestCase("O", 5)]
    public void ColumnContainsCorrectNumberOfItems(string column, int count)
    {
        var numbers = BingoCard.GetCard().Where(x => x.StartsWith(column)).ToList();
        Assert.That(numbers, Has.Count.EqualTo(count));
    }

    [Test, Order(4)]
    public void NumbersAreOrderedByColumn()
    {
        var columns = string.Join("", BingoCard.GetCard().ToList()
            .Select(x => x[..1]).ToArray());

        Assert.That(columns, Does.Match("^[B]*[I]*[N]*[G]*[O]*$"));
    }
    [Order(5)]
    [TestCase("B", 1, 15)]
    [TestCase("I", 16, 30)]
    [TestCase("N", 31, 45)]
    [TestCase("G", 46, 60)]
    [TestCase("O", 61, 75)]
    public void NumbersWithinColumnAreAllInTheCorrectRange(string column, int start, int end)
    {
        var numbers = BingoCard.GetCard().Where(x => x.StartsWith(column)).ToList();

        foreach (var number in numbers)
        {
            var n = Convert.ToInt32(number.Substring(1));
            Assert.That(n, Is.GreaterThanOrEqualTo(start), string.Format("Column {0} should be in the range between {1} and {2}, found: {3}", column, start, end, number));
            Assert.That(n, Is.LessThanOrEqualTo(end), string.Format("Column {0} should be in the range between {1} and {2}, found: {3}", column, start, end, number));
        }
    }

    [Test, Order(6)]
    public void NumbersWithinColumnAreInRandomOrder()
    {
        var card = BingoCard.GetCard().Select(x => Convert.ToInt32(x[1..])).ToArray();

        var isRandom = false;
        for (var i = 1; i < card.Length; i++)
        {
            if (card[i - 1] > card[i])
            {
                isRandom = true;
                break;
            }
        }

        Assert.That(isRandom, Is.True, "Unlikely result, is the list ordered?");
    }
    [Test, Order(7)]
    public void RandomnessTest()
    {
        var card = BingoCard.GetCard();
        var cardNumberCount = (new int[24]).ToList();

        for (var i = 0; i < 100; i++)
        {
            var c = BingoCard.GetCard();
            for (var j = 0; j < 24; j++)
            {
                if (card[j] == c[j])
                {
                    cardNumberCount[j]++;
                }
            }
        }

        Assert.That(cardNumberCount.Any(x => x > 30), Is.False, "The same number appeared on more than 30 of the 100 cards on the same spot, are the cards random?");
    }
}
