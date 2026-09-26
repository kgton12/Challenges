using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class RememberClassTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("apple").Returns(new List<char> { 'p' });
            yield return new TestCaseData("limbojackassin the garden").Returns(new List<char> { 'a', 's', 'i', ' ', 'e', 'n' });
            yield return new TestCaseData("11pinguin").Returns(new List<char> { '1', 'i', 'n' });
            yield return new TestCaseData("HashSets are not guaranteed to preseve order so you could put your return value in a HashSet but to be honest I really wouldn't recommend it").Returns(new List<char> { 's', 'a', 'e', ' ', 't', 'r', 'n', 'o', 'd', 'u', 'p', 'y', 'v', 'l', 'H', 'h', 'S', 'b', 'c', 'm', 'i' });
            yield return new TestCaseData("Claustrophobic").Returns(new List<char> { 'o' });
            yield return new TestCaseData("apPle").Returns(new List<char> { });
            yield return new TestCaseData("11 pinguin").Returns(new List<char> { '1', 'i', 'n' });
            yield return new TestCaseData("pippi").Returns(new List<char> { 'p', 'i' });
            yield return new TestCaseData("Pippi").Returns(new List<char> { 'p', 'i' });
            yield return new TestCaseData("kamehameha").Returns(new List<char> { 'a', 'm', 'e', 'h' });
            yield return new TestCaseData("").Returns(new List<char> { });
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public List<char> Test(string str) =>
      RememberClass.Remember(str);
}

[TestFixture]
public class RandomTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            string letters = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ        ";
            const int Tests = 100;
            Random rnd = new Random();

            for (int i = 0; i < Tests; ++i)
            {
                string str = String.Concat(new char[rnd.Next(0, 100)].Select(_ => letters[rnd.Next(0, letters.Length)]));
                List<char> expected = RememberClass.Remember(str);

                yield return new TestCaseData(str).Returns(expected);
            }
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public List<char> Test(string str) =>
      RememberClass.Remember(str);
}
