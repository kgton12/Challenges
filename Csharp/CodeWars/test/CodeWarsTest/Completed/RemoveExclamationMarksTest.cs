using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RemoveExclamationMarksTest
{
    [Test]
    public static void MyTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveExclamationMarksClass.RemoveExclamationMarks(""), Is.EqualTo(""), "Input: Empty string");
            Assert.That(RemoveExclamationMarksClass.RemoveExclamationMarks("!"), Is.EqualTo(""), "Input: " + "!");
            Assert.That(RemoveExclamationMarksClass.RemoveExclamationMarks("!!"), Is.EqualTo(""), "Input: " + "!!");
            Assert.That(RemoveExclamationMarksClass.RemoveExclamationMarks("Hi!"), Is.EqualTo("Hi"), "Input: " + "Hi!");
            Assert.That(RemoveExclamationMarksClass.RemoveExclamationMarks("!?!"), Is.EqualTo("?"), "Input: " + "!?!");
        }
    }
}
