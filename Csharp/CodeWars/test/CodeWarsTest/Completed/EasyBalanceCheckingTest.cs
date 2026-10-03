using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class EasyBalanceCheckingTest
{
    private static void Dotest(string s, string exp)
    {
        Console.Write("s:\n" + s + "\n");
        string ans = EasyBalanceChecking.Balance(s);
        Assert.That(ans, Is.EqualTo(exp));
    }

    [Test, Order(1)]
    public static void Test1()
    {
        String b1 = "1000.00!=\n125 Market !=:125.45\n126 Hardware =34.95\n127 Video! 7.45\n128 Book   :14.32\n129 Gasoline ::16.10";
        String b1sol = "Original Balance: 1000.00\n125 Market 125.45 Balance 874.55\n126 Hardware 34.95 Balance 839.60\n127 Video 7.45 Balance 832.15\n128 Book 14.32 Balance 817.83\n129 Gasoline 16.10 Balance 801.73\nTotal expense  198.27\nAverage expense  39.65";
        Dotest(b1, b1sol);

        String b2 = "1233.00\n125 Hardware;! 24.80?\n123 Flowers 93.50;\n127 Meat 120.90\n120 Picture 34.00\n124 Gasoline 11.00\n" +
                    "123 Photos;! 71.40?\n122 Picture 93.50\n132 Tyres;! 19.00,?;\n129 Stamps; 13.60\n129 Fruits{} 17.60\n129 Market;! 128.00?\n121 Gasoline;! 13.60?";
        String b2sol = "Original Balance: 1233.00\n125 Hardware 24.80 Balance 1208.20\n123 Flowers 93.50 Balance 1114.70\n127 Meat 120.90 Balance 993.80\n120 Picture 34.00 Balance 959.80\n124 Gasoline 11.00 Balance 948.80\n123 Photos 71.40 Balance 877.40\n122 Picture 93.50 Balance 783.90\n132 Tyres 19.00 Balance 764.90\n129 Stamps 13.60 Balance 751.30\n129 Fruits 17.60 Balance 733.70\n129 Market 128.00 Balance 605.70\n121 Gasoline 13.60 Balance 592.10\nTotal expense  640.90\nAverage expense  53.41";
        Dotest(b2, b2sol);

        String b3 = "1242.00\n122 Hardware;! 13.60\n127 Hairdresser 13.10\n123 Fruits 93.50?;\n132 Stamps;!{ 13.60?;\n160 Pen;! 17.60?;\n002 Car;! 34.00\n";
        String b3sol = "Original Balance: 1242.00\n122 Hardware 13.60 Balance 1228.40\n127 Hairdresser 13.10 Balance 1215.30\n123 Fruits 93.50 Balance 1121.80\n132 Stamps 13.60 Balance 1108.20\n160 Pen 17.60 Balance 1090.60\n002 Car 34.00 Balance 1056.60\nTotal expense  185.40\nAverage expense  30.90";
        Dotest(b3, b3sol);

        String b4 = "1687.00\n160 Perfume;! 71.40?;\n126 Stamps;! 13.60?;\n132 Gasoline;! 54.00?;\n003 Hardware;! 93.50?;\n130 Gasoline;! 34.00?;\n123 Hairdresser;! 12.20?;";
        String b4sol = "Original Balance: 1687.00\n160 Perfume 71.40 Balance 1615.60\n126 Stamps 13.60 Balance 1602.00\n132 Gasoline 54.00 Balance 1548.00\n003 Hardware 93.50 Balance 1454.50\n130 Gasoline 34.00 Balance 1420.50\n123 Hairdresser 12.20 Balance 1408.30\nTotal expense  278.70\nAverage expense  46.45";
        Dotest(b4, b4sol);

        String b5 = "963.00\n131 Books 12.20\n139 Gasoline 120.90\n002 Hardware;! 71.40?;\n";
        String b5sol = "Original Balance: 963.00\n131 Books 12.20 Balance 950.80\n139 Gasoline 120.90 Balance 829.90\n002 Hardware 71.40 Balance 758.50\nTotal expense  204.50\nAverage expense  68.17";
        Dotest(b5, b5sol);
    }
}
