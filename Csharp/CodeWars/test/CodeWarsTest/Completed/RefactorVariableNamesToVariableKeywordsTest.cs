using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RefactorVariableNamesToVariableKeywordsTest
{
    [Test]
    public void TestBoolVariable()
    {
        RefactorVariableNamesToVariableKeywords variables = new();
        Assert.That(CheckType(variables, "bool", typeof(bool)), Is.True);
    }

    [Test]
    public void TestCharVariable()
    {
        RefactorVariableNamesToVariableKeywords variables = new();
        Assert.That(CheckType(variables, "char", typeof(char)), Is.True);
    }

    [Test]
    public void TestSbyteVariable()
    {
        RefactorVariableNamesToVariableKeywords variables = new();
        Assert.That(CheckType(variables, "sbyte", typeof(sbyte)), Is.True);
    }

    private static bool CheckType(object obj, string fieldName, Type expectedType)
    {
        var field = obj.GetType().GetField(fieldName);
        if (field == null) return false;

        return field.FieldType == expectedType;
    }
}
