using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HelpSuzukiCountHisVegetablesTest
{
    private static readonly Tuple<int, string>[] grp1 =
    [
        new(2,"tofu"),
        new(2,"potato"),
        new(2,"cucumber"),
        new(2,"cabbage"),
        new(1,"turnip"),
        new(1,"pepper"),
        new(1,"onion"),
        new(1,"mushroom"),
        new(1,"celery"),
        new(1,"carrot")
    ];

    private static readonly string str1 =
      "potato tofu cucumber cabbage turnip pepper onion carrot celery mushroom potato tofu cucumber cabbage";

    private static readonly Tuple<int, string>[] grp2 =
    [
        new(15,"turnip"),
        new(14,"mushroom"),
        new(13,"cabbage"),
        new(10,"carrot"),
        new(9,"potato"),
        new(7,"onion"),
        new(6,"tofu"),
        new(6,"pepper"),
        new(5,"cucumber"),
        new(4,"celery")
    ];

    private static readonly string str2 =
      "mushroom chopsticks chopsticks turnip mushroom carrot mushroom cabbage mushroom carrot tofu pepper cabbage " +
      "potato cucumber mushroom mushroom potato turnip chopsticks cabbage celery celery turnip pepper chopsticks " +
      "potato potato onion cabbage cucumber onion pepper onion cabbage potato tofu carrot cabbage cabbage turnip " +
      "mushroom cabbage cabbage cucumber cabbage chopsticks turnip pepper onion pepper onion mushroom turnip carrot " +
      "carrot tofu onion tofu chopsticks chopsticks chopsticks mushroom cucumber chopsticks carrot potato cabbage cabbage " +
      "carrot mushroom chopsticks mushroom celery turnip onion carrot turnip cucumber carrot potato mushroom turnip " +
      "mushroom cabbage tofu turnip turnip turnip mushroom tofu potato pepper turnip potato turnip celery carrot turnip";

    [Test, Order(1)]
    public void FixedTest1()
    {
        Assert.That(HelpSuzukiCountHisVegetables.CountVegetables(str1), Is.EqualTo(grp1));
    }

    [Test, Order(2)]
    public void FixedTest2()
    {
        Assert.That(HelpSuzukiCountHisVegetables.CountVegetables(str2), Is.EqualTo(grp2));
    }
}
