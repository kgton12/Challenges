using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

[TestFixture]
class FruitMachineTest
{
    [TestCase]
    [Order(1)]
    public void BasicTest1()
    {
        string[] reel = ["Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack"];
        List<string[]> reels = [reel, reel, reel];
        int[] spins = [0, 0, 0];
        Assert.That(FruitMachine.Fruit(reels, spins), Is.EqualTo(100));
    }

    [TestCase]
    [Order(2)]
    public void BasicTest2()
    {
        string[] reel1 = ["Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack"];
        string[] reel2 = ["Bar", "Wild", "Queen", "Bell", "King", "Seven", "Cherry", "Jack", "Star", "Shell"];
        string[] reel3 = ["Bell", "King", "Wild", "Bar", "Seven", "Jack", "Shell", "Cherry", "Queen", "Star"];
        List<string[]> reels = [reel1, reel2, reel3];
        int[] spins = [5, 4, 3];
        Assert.That(FruitMachine.Fruit(reels, spins), Is.Zero);
    }

    [TestCase]
    [Order(3)]
    public void BasicTest3()
    {
        string[] reel1 = ["King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild"];
        string[] reel2 = ["Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King"];
        string[] reel3 = ["Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell"];
        List<string[]> reels = [reel1, reel2, reel3];
        int[] spins = [0, 0, 1];
        Assert.That(FruitMachine.Fruit(reels, spins), Is.EqualTo(3));
    }

    [TestCase]
    [Order(4)]
    public void BasicTest4()
    {
        string[] reel1 = ["King", "Jack", "Wild", "Bell", "Star", "Seven", "Queen", "Cherry", "Shell", "Bar"];
        string[] reel2 = ["Star", "Bar", "Jack", "Seven", "Queen", "Wild", "King", "Bell", "Cherry", "Shell"];
        string[] reel3 = ["King", "Bell", "Jack", "Shell", "Star", "Cherry", "Queen", "Bar", "Wild", "Seven"];
        List<string[]> reels = [reel1, reel2, reel3];
        int[] spins = [0, 5, 0];
        Assert.That(FruitMachine.Fruit(reels, spins), Is.EqualTo(6));
    }
}
