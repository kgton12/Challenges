using CodeWars.Resolutions;

namespace CodeWarsTest;

public class New5NotesCollectorsTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(New5NotesCollectors.GetNewNotes(2000, new int[] { 500, 160, 400 }), Is.EqualTo(188));
            Assert.That(New5NotesCollectors.GetNewNotes(1260, new int[] { 500, 50, 100 }), Is.EqualTo(122));
            Assert.That(New5NotesCollectors.GetNewNotes(3600, new int[] { 1800, 350, 460, 500, 15 }), Is.EqualTo(95));
            Assert.That(New5NotesCollectors.GetNewNotes(1995, new int[] { 1500, 19, 44 }), Is.EqualTo(86));
        }
    }
}
