using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class HiddenCubicNumbersTest
{
    [Test, Order(1)]
    public void Test1()
    {
        string s = "0 9026315 -827&()"; // "0 0 Lucky"
        string r = "0 0 Lucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(2)]
    public void Test2()
    {
        string s = "Once upon a midnight dreary, while100 I pondered, 9026315weak and weary -827&()"; // "Unlucky"
        string r = "Unlucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(3)]
    public void Test3()
    {
        string s = "Once 1000upon a midnight 110dreary, while100 I pondered, 9026315weak and weary -827&()"; // "0 0 Lucky"
        string r = "0 0 Lucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(4)]
    public void Test4()
    {
        string s = "&z _upon 407298a --- ???ry, ww/100 I thought, 631str*ng and w===y -721&()"; // "407 407 Lucky"
        string r = "407 407 Lucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(5)]
    public void Test5()
    {
        string s = "&z371 upon 407298a --- dreary, ###100.153 I thought, 9926315strong and weary -127&() 1"; // "371 407 153 1 932 Lucky"
        string r = "371 407 153 1 932 Lucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(6)]
    public void Test6()
    {
        string s = "&&[[[ 298.298a --- ;;;, ###100.163 mouse, querty and tired 567"; // "Unlucky"
        string r = "Unlucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(7)]
    public void Test7()
    {
        string s = "&&[[[ 153.153a --- ;;;, ###153153 mouse, querty and tired 153"; // "153 153 153 153 153 765 Lucky"
        string r = "153 153 153 153 153 765 Lucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(8)]
    public void Test8()
    {
        string s = "153000153407000407"; // "153 0 153 407 0 407 1120 Lucky"
        string r = "153 0 153 407 0 407 1120 Lucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }

    [Test, Order(9)]
    public void Test9()
    {
        string s = "Twice upon a midnight dreary, while100 I pondered, 9026315weak and weary -827&()"; // "Unlucky"
        string r = "Unlucky";
        Assert.That(HiddenCubicNumbers.IsSumOfCubes(s), Is.EqualTo(r));
    }
}