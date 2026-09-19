using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class BowlingPinsClassTest
{
    [Test, Order(1)]
    public void ExampleTests()
    {
        int[] testArray = [1, 2, 3];
        Assert.That(BowlingPinsClass.BowlingPins(testArray), Is.EqualTo("I I I I\n I I I \n       \n       "));

        testArray = [3, 5, 9];
        Assert.That(BowlingPinsClass.BowlingPins(testArray), Is.EqualTo("I I   I\n I   I \n  I    \n   I   "));
    }

    [Test, Order(2)]
    public void RandomTests()
    {
        for (int i = 0; i < 50; i++)
        {
            int[] rnd = GetRandomArray();
            string expected = Countdown(rnd);
            Assert.That(BowlingPinsClass.BowlingPins(rnd), Is.EqualTo(expected));
        }
    }

    private static int[] GetRandomArray()
    {
        List<int> arrList = [];
        int times = new Random().Next(0, 11);
        for (int i = 0; i < times; i++)
        {
            int rnd = new Random().Next(1, 11);
            if (arrList.IndexOf(rnd) == -1)
            {
                arrList.Add(rnd);
            }
        }
        return [.. arrList];
    }

    private static string Countdown(int[] arr)
    {
        string pins = "";
        int rowLength = 4;
        int maxLength = 4;
        int[] init = [7, 8, 9, 10, 4, 5, 6, 2, 3, 1];
        for (int i = 0; i < init.Length;)
        {
            pins += new String(' ', maxLength - rowLength);
            for (var r = 0; r < rowLength; r++)
            {
                if (!arr.Contains(init[i]))
                {
                    pins += "I";
                }
                else
                {
                    pins += " ";
                }
                pins += r + 1 < rowLength ? " " : "";
                i++;
            }
            pins += new String(' ', maxLength - rowLength);
            pins += rowLength > 1 ? "\n" : "";
            rowLength--;
        }
        return pins;
    }
}
