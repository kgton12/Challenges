using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class InterviewQuestionEasyTest
{
    [Test]
    public void GenericTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(InterviewQuestionEasy.GetStrings("Chicago"), Is.EqualTo("c:**,h:*,i:*,a:*,g:*,o:*"));
            Assert.That(InterviewQuestionEasy.GetStrings("Bangkok"), Is.EqualTo("b:*,a:*,n:*,g:*,k:**,o:*"));
            Assert.That(InterviewQuestionEasy.GetStrings("Las Vegas"), Is.EqualTo("l:*,a:**,s:**,v:*,e:*,g:*"));
        }
    }
}
