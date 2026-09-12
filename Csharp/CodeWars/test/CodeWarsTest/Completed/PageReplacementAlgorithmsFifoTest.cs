using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PageReplacementAlgorithmsFifoTest
{
    [Test]
    public void Tests()
    {
        List<List<int>> referenceLists =
        [
            [1, 2, 3, 4, 2, 5],
            [],
            [1, 2, 3, 3, 4, 5, 1],
            [1, 1, 1, 2, 2, 3],
            [5, 4, 3, 3, 4, 10],
            [1, 1, 1, 1, 1, 1, 1, 1],
            [10, 9, 8, 7, 7, 8, 7, 6, 5, 4, 3, 4, 3, 4, 5, 6, 5]
        ];

        List<List<int>> results = [
            [4, 5, 3],
            [-1, -1, -1, -1, -1],
            [5, 1, 3, 4],
            [1, 2, 3, -1],
            [10],
            [1, -1, -1],
            [5, 4, 3, 7, 6]
        ];

        int[] ns = [3, 5, 4, 4, 1, 3, 5];

        for (int i = 0; i < referenceLists.Count; i++)
        {
            string referenceListString = string.Join(", ", referenceLists[i]);
            string expectedString = string.Join(", ", results[i]);

            List<int> actual = PageReplacementAlgorithmsFifo.Fifo(ns[i], [.. referenceLists[i]]);
            string actualString = string.Join(", ", actual);

            Assert.That(actual, Is.EqualTo(results[i]),
                $"N = {ns[i]}, REFERENCE LIST = [{referenceListString}]: [{actualString}] should equal [{expectedString}]");
        }
    }
}

[TestFixture, Description("Random Tests")]
public class RandomTests
{
    private static List<int> ReferenceSolution(int n, List<int> referenceList)
    {
        List<int> result = [.. Enumerable.Repeat(-1, n)];
        HashSet<int> referenceSet = [];
        int pointer = 0;

        foreach (int reference in referenceList)
        {
            if (referenceSet.Add(reference))
            {
                referenceSet.Remove(result[pointer]);
                result[pointer] = reference;
                pointer = (pointer + 1) % n;
            }
        }

        return result;
    }

    [Test]
    public void Tests()
    {
        Random generator = new();

        for (int _ = 0; _ < 100; _++)
        {
            List<int> referenceList = [];
            int n = generator.Next(1, 16);

            for (int __ = 0; __ < generator.Next(2, 51); __++)
                referenceList.Add(generator.Next(1, 26));

            string referenceListString = string.Join(", ", referenceList);
            List<int> expected = ReferenceSolution(n, referenceList);

            List<int> actual = PageReplacementAlgorithmsFifo.Fifo(n, [.. referenceList]);
            string actualString = string.Join(", ", actual);

            string expectedString = string.Join(", ", expected);

            Assert.That(actual, Is.EqualTo(expected),
                $"N = {n}, REFERENCE LIST = [{referenceListString}]: [{actualString}] should equal [{expectedString}]");
        }
    }
}