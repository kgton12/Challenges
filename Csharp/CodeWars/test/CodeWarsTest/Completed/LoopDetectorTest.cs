using CodeWars.Completed;
using NUnit.Framework.Internal;

namespace CodeWarsTest.Completed;

public class LoopDetectorTest
{
    private static readonly Random random = new();

    private static (int[], bool) GenerateSelfLoop()
    {
        int length = random.Next(1, 51);
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = length + 100;
        }
        arr[0] = 0;
        return (arr, true);
    }

    private static (int[], bool) GenerateTwoNodeLoop()
    {
        int length = random.Next(2, 51);
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = length + 100;
        }
        arr[0] = 1;
        arr[1] = 0;
        return (arr, true);
    }

    private static (int[], bool) GenerateLargeLoop()
    {
        int size = random.Next(3, 21);
        List<int> arrList = [];

        for (int i = 1; i < size; i++)
        {
            arrList.Add(i);
        }
        arrList.Add(0);

        int tailLen = random.Next(0, 11);
        for (int i = 0; i < tailLen; i++)
        {
            arrList.Add(size + 100);
        }

        return ([.. arrList], true);
    }

    private static (int[], bool) GenerateNoLoop()
    {
        int length = random.Next(5, 51);
        List<int> arrList = [];

        for (int i = 1; i < length; i++)
        {
            arrList.Add(i);
        }
        arrList.Add(length + 10); // last element

        // Shuffle all but the last
        List<int> body = arrList.GetRange(0, arrList.Count - 1);
        Shuffle(body);
        for (int i = 0; i < body.Count; i++)
        {
            arrList[i] = body[i];
        }

        return ([.. arrList], false);
    }

    private static void Shuffle(List<int> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            (list[n], list[k]) = (list[k], list[n]);
        }
    }

    private static (int[], bool) GenerateLargeRandomLoopNoZero()
    {
        int size = random.Next(3, 21); // randint(3,20) equivalent (upper bound exclusive)
        List<int> loopIndices = [.. Enumerable.Range(0, size)];

        // Shuffle list (Fisher-Yates)
        for (int i = size - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (loopIndices[j], loopIndices[i]) = (loopIndices[i], loopIndices[j]);
        }

        // If 0 appears beyond index 0, remove and insert at 0
        int zeroPos = loopIndices.IndexOf(0);
        if (zeroPos > 0)
        {
            loopIndices.RemoveAt(zeroPos);
            loopIndices.Insert(0, 0);
        }

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            int current = loopIndices[i];
            int nextIndex = (i + 1) % size;
            int next = loopIndices[nextIndex];

            if (next == 0)
            {
                var possible = loopIndices.Where(x => x != 0 && x != current).ToList();
                next = possible[random.Next(possible.Count)];
            }

            arr[current] = next;
        }

        return (arr, true);
    }

    private static (int[], bool) GenerateEmpty()
    {
        return ([], false);
    }

    private static (int[], bool) GenerateZeroUnreachable()
    {
        int length = random.Next(5, 21);
        int[] arr = [.. Enumerable.Range(1, length - 1), .. new[] { length + 10 }];
        arr[0] = length + 1;
        arr[random.Next(1, length - 1)] = 0;
        return (arr, false);
    }

    [Test(Description = "Sample Tests that should return true"), Order(1)]
    [TestCase(new int[] { 1, 2, 3, 4, 2 }, true, Description = "{1,2,3,4,2}")]
    [TestCase(new int[] { 0 }, true, Description = "{0}")]
    [TestCase(new int[] { 1, 0 }, true, Description = "{1,0}")]
    [TestCase(new int[] { 2, 0, 1, 5 }, true, Description = "{2,0,1,5}")]
    public void ShouldReturnTrue(int[] arr, bool expected)
    {
        Assert.That(LoopDetector.HasLoop(arr), Is.EqualTo(expected));
    }

    [Test(Description = "Sample Tests that should return false"), Order(2)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, false, Description = "{1,2,3,4,5}")]
    [TestCase(new int[] { 3, 2, 1, 4 }, false, Description = "{3,2,1,4}")]
    [TestCase(new int[] { }, false, Description = "{}")]
    public void ShouldReturnFalse(int[] arr, bool expected)
    {
        Assert.That(LoopDetector.HasLoop(arr), Is.EqualTo(expected));
    }

    [Test(Description = "Random self loops (loop at index 0)"), Order(3)]
    public void RunSelf() => RunTest(LoopDetectorTest.GenerateSelfLoop, 10);

    [Test(Description = "Random two-node loops (loop includes index 0 and 1)"), Order(4)]
    public void RunTwoNode() => RunTest(LoopDetectorTest.GenerateTwoNodeLoop, 10);

    [Test(Description = "Random larger loops (index 0 in the cycle)"), Order(5)]
    public void RunLarge() => RunTest(LoopDetectorTest.GenerateLargeLoop, 10);

    [Test(Description = "Random large loops with no zero value"), Order(6)]
    public void RunNoZero() => RunTest(LoopDetectorTest.GenerateLargeRandomLoopNoZero, 10);

    [Test(Description = "Random no loops (chains that end out of bounds)"), Order(7)]
    public void RunLoopless() => RunTest(LoopDetectorTest.GenerateNoLoop, 10);

    [Test(Description = "Random empty array cases"), Order(8)]
    public void RunEmpty() => RunTest(LoopDetectorTest.GenerateEmpty, 5);

    [Test(Description = "Random unreachable 0s"), Order(9)]
    public void RunUnreachable() => RunTest(LoopDetectorTest.GenerateZeroUnreachable, 5);

    private static void RunTest(Func<(int[], bool)> generator, int numberOfTests)
    {
        for (int _ = 0; _ < numberOfTests; ++_)
        {
            var (arr, expected) = generator();
            Assert.That(LoopDetector.HasLoop(arr), Is.EqualTo(expected), $"Incorrect answer for arr={{{string.Join(",", arr)}}}");
        }
    }

    [Test(Description = "Random mixed types including traps"), Order(10)]
    public static void MixedTests()
    {
        List<Func<(int[], bool)>> generators =
      [
        GenerateSelfLoop,
        GenerateTwoNodeLoop,
        GenerateLargeLoop,
        GenerateNoLoop,
        GenerateEmpty,
        GenerateZeroUnreachable,
        GenerateLargeRandomLoopNoZero
      ];
        for (int _ = 0; _ < 15; ++_)
        {
            var (arr, expected) = generators[random.Next(generators.Count)]();
            Assert.That(LoopDetector.HasLoop(arr), Is.EqualTo(expected), $"Incorrect answer for arr={{{string.Join(",", arr)}}}");
        }
    }
}
