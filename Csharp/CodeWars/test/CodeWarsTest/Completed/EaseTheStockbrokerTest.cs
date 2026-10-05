using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class EaseTheStockbrokerTest
{
    [Test, Order(1)]
    public void Test0()
    {
        String l = "GOOG 90 160.45 B, JPMC 67 12.8 S, MYSPACE 24.0 210 B, CITI 50 450 B, CSCO 100 55.5 S";
        String r = "Buy: 14440 Sell: 6408; Badly formed 2: MYSPACE 24.0 210 B ;CITI 50 450 B ;";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(2)]
    public void Test1()
    {
        String l = "GOOG 300 542.0 B, AAPL 50 145.0 B, CSCO 250.0 29 B, GOOG 200 580.0 S";
        String r = "Buy: 169850 Sell: 116000; Badly formed 1: CSCO 250.0 29 B ;";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(3)]
    public void Test2()
    {
        String l = "ZNGA 1300 2.66 B, CLH15.NYM 50 56.32 B, OWW 1000 11.623 B, OGG 20 580.1 B";
        String r = "Buy: 29499 Sell: 0";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(4)]
    public void Test3()
    {
        String l = "GOOG 300 542.93 B, CLH15.NYM 50 56.32 S, CSCO 250 29.46 B, OGG 20 580.1 B";
        String r = "Buy: 181846 Sell: 2816";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(5)]
    public void Test4()
    {
        String l = "ZNGA 1300 2.66 B, GOOG 200 580.12 S, OWW 1000 11.623 B, BAC 200 16.67 B";
        String r = "Buy: 18415 Sell: 116024";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(6)]
    public void Test5()
    {
        String l = "ZNGA 1300 2.66 S, CLH15.NYM 50 56.32 S, OWW 1000 11.623 S, OGG 20 580.1 S";
        String r = "Buy: 0 Sell: 29499";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(7)]
    public void Test6()
    {
        String l = "";
        String r = "Buy: 0 Sell: 0";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(8)]
    public void Test7()
    {
        String l = "ZNGA 1300 2.66, CLH15.NYM 50 56.32 S, OWW 1000 11.623 S, OGG 20 580.1 S";
        String r = "Buy: 0 Sell: 26041; Badly formed 1: ZNGA 1300 2.66 ;";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }

    [Test, Order(9)]
    public void Test8()
    {
        String l = "CAP 1300 .2 B, CLH16.NYM 50 56 S, OWW 1000 11 S, OGG 20 580.1 S";
        String r = "Buy: 260 Sell: 11602; Badly formed 2: CLH16.NYM 50 56 S ;OWW 1000 11 S ;";
        Assert.That(EaseTheStockbroker.BalanceStatements(l), Is.EqualTo(r));
    }
}
