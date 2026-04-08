using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RemoveStringSpacesTest
{
    [Test, Order(1)]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveStringSpaces.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"), Is.EqualTo("8j8mBliB8gimjB8B8jlB"));
            Assert.That(RemoveStringSpaces.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"), Is.EqualTo("88Bifk8hB8BB8BBBB888chl8BhBfd"));
            Assert.That(RemoveStringSpaces.NoSpace("8aaaaa dddd r     "), Is.EqualTo("8aaaaaddddr"));
        }
    }
}
