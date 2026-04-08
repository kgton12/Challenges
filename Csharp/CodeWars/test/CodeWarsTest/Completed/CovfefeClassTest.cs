using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CovfefeClassTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CovfefeClass.Covfefe("coverage"), Is.EqualTo("covfefe"));
            Assert.That(CovfefeClass.Covfefe("coverage coverage"), Is.EqualTo("covfefe covfefe"));
            Assert.That(CovfefeClass.Covfefe("nothing"), Is.EqualTo("nothing covfefe"));
            Assert.That(CovfefeClass.Covfefe("double space "), Is.EqualTo("double space  covfefe"));
            Assert.That(CovfefeClass.Covfefe("covfefe"), Is.EqualTo("covfefe covfefe"));
            Assert.That(CovfefeClass.Covfefe(""), Is.EqualTo(" covfefe"));
        }
    }
}
