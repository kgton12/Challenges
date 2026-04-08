using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CheckTheExamTest
{
    [TestCase(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }, 6)]
    [TestCase(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }, 7)]
    [TestCase(new string[] { "a", "a", "b", "c" }, new string[] { "a", "a", "b", "c" }, 16)]
    [TestCase(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }, 0)]
    public void SampleTest(string[] arr1, string[] arr2, int score)
    {
        Assert.That(CheckTheExam.CheckExam(arr1, arr2), Is.EqualTo(score));
    }
}
