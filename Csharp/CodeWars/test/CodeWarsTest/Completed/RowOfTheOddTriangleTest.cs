using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RowOfTheOddTriangleTest
{
    [Test, Order(1)]
    public void FixedTest1()
    {
        Assert.That(RowOfTheOddTriangle.OddRow(1), Is.EqualTo(new long[] { 1 }));
    }

    [Test, Order(2)]
    public void FixedTest2()
    {
        Assert.That(RowOfTheOddTriangle.OddRow(2), Is.EqualTo(new long[] { 3, 5 }));
    }

    [Test, Order(3)]
    public void FixedTest13()
    {
        Assert.That(RowOfTheOddTriangle.OddRow(13), Is.EqualTo(new long[] { 157, 159, 161, 163, 165, 167, 169, 171, 173, 175, 177, 179, 181 }));
    }

    [Test, Order(4)]
    public void FixedTest19()
    {
        Assert.That(RowOfTheOddTriangle.OddRow(19), Is.EqualTo(new long[] { 343, 345, 347, 349, 351, 353, 355, 357, 359, 361, 363, 365, 367, 369, 371, 373, 375, 377, 379 }));
    }

    [Test, Order(5)]
    public void FixedTest41()
    {
        Assert.That(RowOfTheOddTriangle.OddRow(41), Is.EqualTo(new long[]{1641, 1643, 1645, 1647, 1649, 1651, 1653, 1655, 1657, 1659, 1661, 1663, 1665, 1667, 1669,
    1671, 1673, 1675, 1677, 1679, 1681, 1683, 1685, 1687, 1689, 1691, 1693, 1695, 1697, 1699,
    1701, 1703, 1705, 1707, 1709, 1711, 1713, 1715, 1717, 1719, 1721  }));
    }
}
