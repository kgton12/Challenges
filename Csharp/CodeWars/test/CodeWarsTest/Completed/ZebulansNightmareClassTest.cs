using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ZebulansNightmareClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("camel_case"), Is.EqualTo("camelCase"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("mark_as_issue"), Is.EqualTo("markAsIssue"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("copy_paste_pep8"), Is.EqualTo("copyPastePep8"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("goto_next_kata"), Is.EqualTo("gotoNextKata"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("repeat"), Is.EqualTo("repeat"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("trolling_is_fun"), Is.EqualTo("trollingIsFun"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("why"), Is.EqualTo("why"));
            Assert.That(ZebulansNightmareClass.ZebulansNightmare("123_abc_def"), Is.EqualTo("123AbcDef"));
        }
    }
}
