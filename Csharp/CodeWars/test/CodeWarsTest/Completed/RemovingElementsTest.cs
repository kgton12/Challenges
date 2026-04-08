using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RemovingElementsTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemovingElements.RemoveEveryOther(["Hello", "Goodbye", "Hello Again"]), Is.EqualTo(new object[] { "Hello", "Hello Again" }));
            Assert.That(RemovingElements.RemoveEveryOther([new object[] { 1, 2 }]), Is.EqualTo(new object[] { new object[] { 1, 2 } }));
            Assert.That(RemovingElements.RemoveEveryOther([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]), Is.EqualTo(new object[] { 1, 3, 5, 7, 9 }));
            Assert.That(RemovingElements.RemoveEveryOther([new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } }]), Is.EqualTo(new object[] { new object[] { "Goodbye" } }));
            Assert.That(RemovingElements.RemoveEveryOther([]), Is.EqualTo(Array.Empty<object>()));
        }
    }
}
