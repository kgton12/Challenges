using CodeWars.Completed;
using System.Numerics;
using System.Text;

namespace CodeWarsTest.Completed;

public class SumOfGroupsTest
{
    [Test, Order(1)]
    public void TestExample1()
    {
        var numbers = new BigInteger[] { 1234, 3142, 66654, 65466, 2143 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(19));
    }

    [Test, Order(2)]
    public void TestExample2()
    {
        var numbers = new BigInteger[] { 12345, 54321, 98765, 56789, 12354, 54312 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(23));
    }

    [Test, Order(3)]
    public void TestExample3()
    {
        var numbers = new BigInteger[] { 111, 11, 1, 222, 22, 2 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.Zero);
    }

    [Test, Order(4)]
    public void TestSingleElement()
    {
        var numbers = new BigInteger[] { 1234567890 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.Zero);
    }

    [Test, Order(5)]
    public void TestSingleElementZero()
    {
        var numbers = new BigInteger[] { 0 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.Zero);
    }

    [Test, Order(6)]
    public void TestNoAnagramGroups()
    {
        var numbers = new BigInteger[] { 123, 456, 789, 101112 };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.Zero);
    }

    [Test, Order(7)]
    public void TestLargeNumbers()
    {
        var numbers = new BigInteger[]
        {
            BigInteger.Parse("12345678901234567890"),
            BigInteger.Parse("98765432109876543210"),
            BigInteger.Parse("12345678901234567890"),
            BigInteger.Parse("09876543210987654321")

        };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(90)); // Ejemplo de suma de dígitos después del cálculo
    }

    [Test, Order(8)]
    public void TestVeryLargeNumbers()
    {
        var numbers = new BigInteger[]
        {
            BigInteger.Parse("10000000000050000000000000000000000000000000000000"),
            BigInteger.Parse("10000000000000000000005000000000000000000000000000"),
            BigInteger.Parse("10000000000000005000000000000000000000000000000000"),
            BigInteger.Parse("10000000000000000000000000000000500000000000000000"),
            BigInteger.Parse("10000000000000000000000005000000000000000000000000"),
            BigInteger.Parse("10000000000000050000000000000000000000000000000000"),
            BigInteger.Parse("899"),
            BigInteger.Parse("989"),
            BigInteger.Parse("123")
        };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(32)); // Ejemplo de suma de dígitos después del cálculo
    }

    [Test, Order(9)]
    public void TestMultipleAnagramGroups()
    {
        var numbers = new BigInteger[]
        {
            BigInteger.Parse("1122"),
            BigInteger.Parse("2211"),
            BigInteger.Parse("1221"),
            BigInteger.Parse("2112"),
            BigInteger.Parse("3333"),
            BigInteger.Parse("3333"),
            BigInteger.Parse("3333")
        };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(18)); // 1122 (del primer grupo) + 3333 (del segundo grupo) = 4455 => 4 + 4 + 5 + 5 = 18
    }

    [Test, Order(10)]
    public void TestWithLeadingZeros()
    {
        var numbers = new BigInteger[]
        {
            BigInteger.Parse("00123"),
            BigInteger.Parse("123"),
            BigInteger.Parse("0123"),
            BigInteger.Parse("23100")
        };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(6));  // Ejemplo de grupo con ceros a la izquierda
    }

    [Test, Order(11)]
    public void TestIdenticalNumbers()
    {
        var numbers = new BigInteger[]
        {
            BigInteger.Parse("3333"),
            BigInteger.Parse("3333"),
            BigInteger.Parse("3333")
        };
        var result = SumOfGroups.SumOfDigitGroups(numbers);
        Assert.That(result, Is.EqualTo(12));  // 3333 es el único número y se selecciona para el cálculo
    }

    static readonly Random rand = new(DateTime.Now.Millisecond);

    [Test, Order(12)]
    public void SmallRandomTest()
    {
        for (int i = 0; i < 10; i++)
        {
            var lista = GenerateRandomArray(100);
            int actual = SumOfGroups.SumOfDigitGroups(lista);
            int expected = SumOfDigitGroupsSolution(lista);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test, Order(13)]
    public void MediumRandomTest()
    {
        for (int i = 0; i < 50; i++)
        {
            var lista = GenerateRandomArray(500);
            int actual = SumOfGroups.SumOfDigitGroups(lista);
            int expected = SumOfDigitGroupsSolution(lista);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    [Test, Order(14)]
    public void BigRandomTest()
    {
        for (int i = 0; i < 500; i++)
        {
            var lista = GenerateRandomArray(1000);
            int actual = SumOfGroups.SumOfDigitGroups(lista);
            int expected = SumOfDigitGroupsSolution(lista);
            Assert.That(actual, Is.EqualTo(expected), $"Test {i + 1} failed. Expected: {expected}, Actual: {actual}");
        }
    }

    /// <summary>
    /// Method to generate random BigInteger arrays
    /// </summary>
    /// <param name = "tamArray"></param>
    /// <param name="rand"></param>
    /// <returns></returns>
    private static BigInteger[] GenerateRandomArray(int tamArray)
    {
        List<BigInteger> list = [];

        int i = 0;

        while (i < tamArray)
        {
            int tamGrupo = rand.Next(2, 20);
            list.AddRange(CreateGroup(rand.Next(1, 51), tamGrupo));
            i += tamGrupo;
        }

        return [.. list];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="numberSize"></param>
    /// <param name="arrSize">Cantidad de permutaciones donde puede haber repetidos</param>
    /// <returns></returns>
    private static BigInteger[] CreateGroup(int numberSize, int arrSize)
    {
        BigInteger numero = CreateNumber(numberSize);

        while (numero.ToString().Length != numberSize)
        {
            numero = CreateNumber(numberSize);
        }

        List<BigInteger> grupoAleatorio = new List<BigInteger>();

        while (grupoAleatorio.Count < arrSize)
        {
            if (numero.ToString().Length == numberSize)
            {
                grupoAleatorio.Add(numero);
            }
            numero = CreateAnagram(numero);
        }

        return [.. grupoAleatorio];
    }

    private static BigInteger CreateNumber(int numberSize)
    {
        StringBuilder sb = new();
        sb.Append(rand.Next(1, 10));  // Primer dígito no puede ser 0

        for (int i = 1; i < numberSize; i++)
        {
            sb.Append(rand.Next(0, 10));  // Dígitos restantes (puede haber 0)  
        }
        return BigInteger.Parse(sb.ToString());
    }

    private static BigInteger CreateAnagram(BigInteger numero)
    {
        string aux = numero.ToString();
        char[] numArray = aux.ToCharArray();

        do
        {
            // Barajar los dígitos
            for (int i = numArray.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                // Intercambiar elementos
                (numArray[j], numArray[i]) = (numArray[i], numArray[j]);
            }
        }
        while (numArray[0] == '0'); // Repetir si el primer dígito es '0'

        return BigInteger.Parse(new string(numArray));
    }

    private static string Shuffle(string numero)
    {
        char[] numArray = numero.ToCharArray();
        int n = numArray.Length;

        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            (numArray[n], numArray[k]) = (numArray[k], numArray[n]);
        }

        return new string(numArray);
    }

    private static int SumOfDigitGroupsSolution(BigInteger[] numbers)
    {
        // Agrupamos los números por su patrón de anagrama y seleccionamos los grupos con más de un elemento
        var groupSums = numbers
            .GroupBy(number => String.Concat(number.ToString().OrderBy(c => c)))
            .Where(group => group.Count() > 1)
            .Select(group => group.Min());  // Seleccionar el menor número en cada grupo

        // Sumar todos los números seleccionados manualmente
        BigInteger totalSum = new(0);
        foreach (var sum in groupSums)
        {
            totalSum += sum;
        }

        // Convertir la suma total a cadena y sumar sus dígitos
        return totalSum.ToString().Sum(c => c - '0');
    }
}
