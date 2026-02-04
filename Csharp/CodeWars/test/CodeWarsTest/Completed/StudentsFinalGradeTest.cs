using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class StudentsFinalGradeTest
{
    [Test]
    public void FinalGradeTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StudentsFinalGrade.FinalGrade(100, 12), Is.EqualTo(100));
            Assert.That(StudentsFinalGrade.FinalGrade(85, 5), Is.EqualTo(90));
        }
    }
}
