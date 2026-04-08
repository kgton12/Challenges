using CodeWars.Completed;
using System.Text;

namespace CodeWarsTest.Completed;

public class CompleteSeriesClassTest
{
    private readonly int[] test1 = [0, 1],
            test2 = [1, 4, 6],
            test3 = [3, 4, 5],
            test4 = [2, 1],
            test5 = [1, 4, 4, 6],
            sol1 = [0, 1],
            sol2 = [0, 1, 2, 3, 4, 5, 6],
            sol3 = [0, 1, 2, 3, 4, 5],
            sol4 = [0, 1, 2],
            sol5 = [0];

    [Test, Order(1)]
    public void Test1()
    {
        int[] actual = CompleteSeriesClass.CompleteSeries(test1);
        Console.WriteLine(String.Format("Input Array: {0}\nExpected Array: {1}\nActual Array: {2}",
                          FormatArray(test1), FormatArray(sol1), FormatArray(actual)));
        Assert.That(actual, Is.EqualTo(sol1));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] actual = CompleteSeriesClass.CompleteSeries(test2);
        Console.WriteLine(String.Format("Input Array: {0}\nExpected Array: {1}\nActual Array: {2}",
                          FormatArray(test2), FormatArray(sol2), FormatArray(actual)));
        Assert.That(actual, Is.EqualTo(sol2));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] actual = CompleteSeriesClass.CompleteSeries(test3);
        Console.WriteLine(String.Format("Input Array: {0}\nExpected Array: {1}\nActual Array: {2}",
                          FormatArray(test3), FormatArray(sol3), FormatArray(actual)));
        Assert.That(actual, Is.EqualTo(sol3));
    }

    [Test, Order(4)]
    public void Test4()
    {
        int[] actual = CompleteSeriesClass.CompleteSeries(test4);
        Console.WriteLine(String.Format("Input Array: {0}\nExpected Array: {1}\nActual Array: {2}",
                          FormatArray(test4), FormatArray(sol4), FormatArray(actual)));
        Assert.That(actual, Is.EqualTo(sol4));
    }

    [Test, Order(5)]
    public void Test5()
    {
        int[] actual = CompleteSeriesClass.CompleteSeries(test5);
        Console.WriteLine(String.Format("Input Array: {0}\nExpected Array: {1}\nActual Array: {2}",
                          FormatArray(test5), FormatArray(sol5), FormatArray(actual)));
        Assert.That(actual, Is.EqualTo(sol5));
    }

    private static String FormatArray(int[] arr)
    {
        StringBuilder builder = new("{ ");
        bool first = true;
        foreach (var item in arr)
        {
            builder.Append((first ? "" : ", ") + item);
            if (first)
            {
                first = false;
            }
        }
        builder.Append(" }");
        return builder.ToString();
    }
}
