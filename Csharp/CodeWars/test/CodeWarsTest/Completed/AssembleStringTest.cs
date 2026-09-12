using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class AssembleStringTest
{
    private static void DoTest(string[] input, string expected)
    {
        string message = String.Format("\ninput = {{\n{0}\n}}\n",
            string.Join(",\n", input.Select(s => "    \"" + s + "\"")));
        string actual = AssembleString.Assemble(input);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test, Order(1)]
    public void SampleTests()
    {
        DoTest(["a*cde", "*bcde", "abc*e"], "abcde");
        DoTest(["a*c**", "**cd*", "a*cd*"], "a#cd#");
        DoTest(["*ashtag ** *", "h*sht*g *> *", "has*tag -* *"], "hashtag -> #");
    }

    [Test, Order(2)]
    public void SpecialTests()
    {
        DoTest(["abcde", "abcde", "abcde"], "abcde");
        DoTest(["*****", "*****", "*****"], "#####");
        DoTest([], "");
        DoTest(["", "", ""], "");
    }

    [Test, Order(3)]
    public void RandomTests()
    {
        Random random = new();
        for (int test = 0; test < 100; test++)
        {
            int rows = random.Next(1, 15);
            int cols = random.Next(1, 15);

            char[] clearText = new char[cols];
            for (int i = 0; i < cols; i++)
                clearText[i] = (char)random.Next('a', 'z' + 1);

            char[] deciphered = new char[cols];
            Array.Fill(deciphered, '#');

            char[][] matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
                matrix[row] = new char[cols];

            int star_percent = random.Next(100 + 1);
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    char ch = (random.Next(0, 100) < star_percent) ? '*' : clearText[col];
                    matrix[row][col] = ch;
                    if (ch != '*')
                        deciphered[col] = ch;
                }
            }
            string[] strings = [.. matrix.Select(chars => new string(chars))];
            DoTest(strings, new string(deciphered));
        }
    }
}
