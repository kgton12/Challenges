using CodeWars.Completed;
using System.Numerics;

namespace CodeWarsTest.Completed;

public class SumConsecutiveSumTest
{
    static readonly Random rand = new(DateTime.Now.Millisecond);

    [Test]
    [Order(1)]
    public void TestMultipleSubsets()
    {
        var arr = new BigInteger[] { 1, 2, 5, 6, 10, 11, 12 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.EqualTo(11));
    }

    [Test]
    [Order(2)]
    public void BasicTest()
    {
        var arrays = new BigInteger[][]
        {
           [3, 1, 100, 120, 101, 99, 2],
           [3, 1000, 1005, 1000, 1000, 1000, 6, 7, 1003, 1004, 4, 5, 1002, 8, 9, 1001, 1004],
           [3, 1000, 1005, 1000, 9999999, 1000, 1000, 6, 7, 1003, 1004, 4, 5, 1002, 8, 9, 1001, 1004]
        };

        int actual = SumConsecutiveSum.ConsecutiveSum(arrays[0]);
        Assert.That(actual, Is.EqualTo(9));
        actual = SumConsecutiveSum.ConsecutiveSum(arrays[1]);
        Assert.That(actual, Is.EqualTo(18));
        actual = SumConsecutiveSum.ConsecutiveSum(arrays[2]);
        Assert.That(actual, Is.EqualTo(18));
    }

    [Test]
    [Order(3)]
    public void TestLargeNumbers()
    {
        var large = new BigInteger[][]
        {
            [BigInteger.Parse("99999999999999999999999999999999999999999999999999"),BigInteger.Parse("100000000000000000000000000000000000000000000000000"), BigInteger.Parse("100000000000000000000000000000000000000000000000001")],
            [BigInteger.Parse("100000000000"),BigInteger.Parse("100000000001"),BigInteger.Parse("100000000002")]
        };

        Assert.That(SumConsecutiveSum.ConsecutiveSum(large[0]), Is.EqualTo(3));
        Assert.That(SumConsecutiveSum.ConsecutiveSum(large[1]), Is.EqualTo(6));
    }

    [Test]
    [Order(4)]
    public void TestSingleElement()
    {
        var arr = new BigInteger[] { 1 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.Zero);
    }

    [Test]
    [Order(5)]
    public void TestTwoAndConsecutives()
    {
        var arr = new BigInteger[] { 50, 51 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    [Order(6)]
    public void TestNoConsecutives()
    {
        var arr = new BigInteger[] { 10, 20, 30, 40 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.Zero);
    }

    [Test]
    [Order(7)]
    public void TestAllConsecutives()
    {
        var arr = new BigInteger[] { 1, 2, 3, 4, 5 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    [Order(8)]
    public void TestWithDuplicates()
    {
        var arr1 = new BigInteger[] { 8, 8, 8, 8, 3, 8, 8, 3, 4, 5, 6, 5, 1, 2, 2, 6, 6, 6, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8 };
        var arr2 = GenerateRandomBigIntegerArrayDuplicates(50, 50, 1000);

        int actual1 = SumConsecutiveSum.ConsecutiveSum(arr1);
        int actual2 = SumConsecutiveSum.ConsecutiveSum(arr2);

        Assert.That(actual1, Is.EqualTo(9));
        Assert.That(actual2, Is.EqualTo(ConsecutiveSum(Shuffle(arr2))));
    }

    [Test]
    [Order(9)]
    public void TestLongSequence()
    {
        var arr = new BigInteger[] { 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 11, 12, 13, 14 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    [Order(10)]
    public void TestLongConsecutiveSequence()
    {
        var listaNums = new BigInteger[10000];
        int expected = 0;
        for (int i = 1; i <= 10000; i++)
        {
            expected += i;
            listaNums[i - 1] = i;
        }
        int result = SumConsecutiveSum.ConsecutiveSum(Shuffle(listaNums));
        int expectedSum = expected.ToString().Sum(c => c - '0');
        Assert.That(result, Is.EqualTo(expectedSum));
    }

    [Test]
    [Order(11)]
    public void TestNonConsecutiveSequence()
    {
        var arr = new BigInteger[] { 1, 3, 5, 7, 9, 11, 13 };
        int result = SumConsecutiveSum.ConsecutiveSum(arr);
        Assert.That(result, Is.Zero);
    }

    [Test]
    [Order(12)]
    public void AllConsecutivesBigNumbersTest()
    {
        var listaConsecutivos = new BigInteger[1000];
        BigInteger num = BigInteger.Parse("1" + new string('0', 50));
        BigInteger sumConsecutiveNumbers = 0;

        for (int i = 0; i < 1000; i++)
        {
            listaConsecutivos[i] = num;
            sumConsecutiveNumbers += num;
            num += 1;
        }

        int result = SumConsecutiveSum.ConsecutiveSum(Shuffle(listaConsecutivos));
        int expectedSum = sumConsecutiveNumbers.ToString().Sum(c => c - '0');
        Assert.That(result, Is.EqualTo(expectedSum));
    }

    [Test]
    [Order(13)]
    public void AllNonConsecutivesTest()
    {
        var nonConsecutivesList = new BigInteger[1000];
        BigInteger num = BigInteger.Parse("1" + new string('0', 50));

        for (int i = 0; i < 1000; i++)
        {
            nonConsecutivesList[i] = num;
            num += rand.Next(2, 100);
        }

        int result = SumConsecutiveSum.ConsecutiveSum(Shuffle(nonConsecutivesList));
        Assert.That(result, Is.Zero);
    }

    [Test]
    [Order(14)]
    public void AllNonConsecutivesDuplicatesTest()
    {
        var nonConsecutivesList = new List<BigInteger>();
        BigInteger num = BigInteger.Parse("1" + new string('0', 50));
        Random rand = new();
        int cont = 0;

        while (cont < 1000)
        {
            int rep = rand.Next(2, 50);
            for (int r = 0; r < rep; r++)
            {
                nonConsecutivesList.Add(num);
                cont++;
            }

            num += 10;
            cont++;
        }

        int result = SumConsecutiveSum.ConsecutiveSum(Shuffle([.. nonConsecutivesList]));
        Assert.That(result, Is.Zero);
    }

    [Test]
    [Order(15)]
    public void TestRandomMultipleArrays()
    {
        for (int i = 0; i < 10; i++)
        {
            BigInteger[] arr = GenerateRandomBigIntegerArrayDuplicates(50, 50, 100);
            int actual = SumConsecutiveSum.ConsecutiveSum(arr);
            int expected = ConsecutiveSum(arr);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test]
    [Order(16)]
    public void SmallRandomConsecutivesTest()
    {
        for (int i = 0; i < 10; i++)
        {
            BigInteger[] arr = GenerateConsecutiveRandomBigIntegerArray(100);
            int expected = ConsecutiveSum(arr);
            int actual = SumConsecutiveSum.ConsecutiveSum(arr);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test]
    [Order(17)]
    public void MediumRandomConsecutivesTest()
    {
        for (int i = 0; i < 20; i++)
        {
            BigInteger[] arr = GenerateConsecutiveRandomBigIntegerArray(1000);
            int expected = ConsecutiveSum(arr);
            int actual = SumConsecutiveSum.ConsecutiveSum(arr);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test]
    [Order(18)]
    public void BigRandomConsecutivesTest()
    {
        for (int i = 0; i < 10; i++)
        {
            BigInteger[] arr = GenerateConsecutiveRandomBigIntegerArray((int)Math.Pow(10, 5));
            int expected = ConsecutiveSum(arr);
            int actual = SumConsecutiveSum.ConsecutiveSum(arr);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test]
    [Order(19)]
    public void DuplicatesRandomTest()
    {
        for (int i = 0; i < 10; i++)
        {
            BigInteger[] arr = GenerateRandomBigIntegerArrayDuplicates(50, 20, 1000);
            int expected = ConsecutiveSum(arr);
            int actual = SumConsecutiveSum.ConsecutiveSum(arr);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test]
    [Order(20)]
    public void NonConsecutivesRandomTest()
    {
        for (int i = 0; i < 10; i++)
        {
            BigInteger[] arr = GenerateNonConsecutiveBigIntegerArray(1000);
            int actual = SumConsecutiveSum.ConsecutiveSum(arr);
            Assert.That(actual, Is.Zero, $"Test {i + 1} failed. Expected: {0}, Actual: {actual}");
        }
    }

    private static BigInteger[] GenerateNonConsecutiveBigIntegerArray(int arraySize)
    {
        Random rand = new();
        var array = new BigInteger[arraySize];
        BigInteger num = GenerateRandomBigInteger(51);

        for (int i = 0; i < arraySize; i++)
        {
            num += rand.Next(2, 100);
            array[i] = num;
        }

        return Shuffle(array);
    }

    private static BigInteger[] Shuffle(BigInteger[] array)
    {
        Random rand = new();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            (array[n], array[k]) = (array[k], array[n]);
        }
        return array;
    }

    #region Generators
    /// <summary>
    /// Genera un entero grande de la cantidad de digitos pasada por parametro
    /// </summary>
    /// <param name="rand">Para generar el digito aleatorio</param>
    /// <param name="len">Cantidad de digitos del numero</param>
    /// <returns></returns>
    static BigInteger GenerateRandomBigInteger(int len)
    {
        return BigInteger.Parse(rand.Next(1, 10).ToString() + string.Concat(Enumerable.Range(0, len - 1).Select(_ => rand.Next(0, 10))));
    }

    /// <summary>
    /// Genera subarrays consecutivos si se da la condicion, de lo contrario genera numeros aleatorios
    /// </summary>
    /// <param name="tamArray"></param>
    /// <returns></returns>
    private static BigInteger[] GenerateConsecutiveRandomBigIntegerArray(int tamArray)
    {
        var outputList = new List<BigInteger>();

        while (outputList.Count < tamArray)
        {
            BigInteger num = GenerateRandomBigInteger(50);
            int consecutives = rand.Next(0, 100) > 80 ? rand.Next(2, rand.Next(10, 15)) : 1;
            consecutives = Math.Min(consecutives, tamArray - outputList.Count); // Ajuste si excede el tamaño restante

            outputList.AddRange(Enumerable.Range(0, consecutives).Select(_ => num++));
        }

        return Shuffle([.. outputList]);
    }

    private static BigInteger[] GenerateRandomBigIntegerArrayDuplicates(int maxLenNum, int maxRep, int tamArray)
    {
        var outputList = new List<BigInteger>();
        BigInteger num = GenerateRandomBigInteger(maxLenNum);

        while (outputList.Count < tamArray)
        {
            int rep = rand.Next(0, 100) > 80 ? rand.Next(2, maxRep) : 1;
            rep = Math.Min(rep, tamArray - outputList.Count); // Ajusta rep si excede el tamaño restante

            outputList.AddRange(Enumerable.Repeat(num, rep));
            num++;
        }

        return Shuffle([.. outputList]);
    }
    #endregion

    private static int ConsecutiveSum(BigInteger[] arr)
    {
        var set = new HashSet<BigInteger>(arr);
        BigInteger sum = 0;

        foreach (BigInteger elem in set)
        {
            BigInteger currentNum = elem;
            BigInteger previousNum = currentNum - 1;

            if (!set.Contains(previousNum))
            {
                BigInteger currentSum = 0;
                int count = 0;

                while (set.Contains(currentNum))
                {
                    currentSum += currentNum;
                    currentNum += 1;
                    count++;
                }

                if (count >= 2)
                {
                    sum += currentSum;
                }
            }
        }

        return sum.ToString().Sum(c => c - '0');
    }
}