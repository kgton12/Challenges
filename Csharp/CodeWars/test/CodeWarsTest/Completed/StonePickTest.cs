using CodeWars.Completed;

namespace CodeWarsTest.Completed
{
    internal class StonePickTest
    {
        private static readonly Random rnd = new();

        [TestCase("SSSSCCCCCC", 2)]
        [TestCase("SSC", 0)]
        [TestCase("SSSSwwwDDDDDD", 0)]
        [TestCase("WWCCCCCCCCCCCC", 4)]
        public void ExampleTestCase(string testString, int expected)
        {
            var arr = StringToMinecraftArrayConverter(testString);
            var actual = StonePickaxeCrafting.StonePick(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("SSSSCCC", 1)]
        [TestCase("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSCCCCCCCCCCCCCCCCCCCCCCCCC", 8)]
        [TestCase("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS" +
            "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC", 21)]
        public void PicksGreaterThanOrEqualTo1(string testString, int expected)
        {
            var arr = StringToMinecraftArrayConverter(testString);
            var actual = StonePickaxeCrafting.StonePick(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("SWDdsCSCC", 1)]
        [TestCase("wDdSCC", 0)]
        [TestCase("wwwwwwwwwwSSSSSSSSSSSsssssssssssCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC" +
            "CCCCCCCCCCCdddddddd", 5)]
        public void PicksWithNonEligibleMaterials(string testString, int expected)
        {
            var arr = StringToMinecraftArrayConverter(testString);
            var actual = StonePickaxeCrafting.StonePick(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("wDdS", 0)]
        [TestCase("WDCS", 0)]
        [TestCase("DDDDDDDDDDDDDDDCCCCCCCCCCCCCCCCCCCCSwwwwwwwwwwwwwwwddddddddddd", 0)]
        public void NoPicks(string testString, int expected)
        {
            var arr = StringToMinecraftArrayConverter(testString);
            var actual = StonePickaxeCrafting.StonePick(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW" +
            "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC" +
            "CCCCCCCCCCCCCCCCCCCCC", 30)]
        [TestCase("WWWWWWWWWWWWCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC" +
            "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC", 24)]
        [TestCase("WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWCCCCCCCCCCCCCCCCCCCC" +
            "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC", 16)]
        public void PicksWithWoodAndSticksOnly(string testString, int expected)
        {
            var arr = StringToMinecraftArrayConverter(testString);
            var actual = StonePickaxeCrafting.StonePick(arr);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NoMaterials()
        {
            var arr = StringToMinecraftArrayConverter("");
            var actual = StonePickaxeCrafting.StonePick(arr);
            Assert.That(actual, Is.Zero);
        }

        [Test]
        public void RandomTests()
        {
            var strings = GenerateRandomExamples();
            foreach (var str in strings)
            {
                var arr = StringToMinecraftArrayConverter(str);
                var actual = StonePickaxeCrafting.StonePick(arr);
                var expected = Math.Min(arr.Sum(x => x == "Cobblestone" ? 1 : 0) / 3,
                arr.Sum(x => x == "Wood" ? 4 : x == "Sticks" ? 1 : 0) / 2);
                Assert.That(actual, Is.EqualTo(expected), "Arr => " + String.Join(", ", arr.Select(x => x)));
            }
        }

        private static string[] StringToMinecraftArrayConverter(string s)
        {
            Dictionary<char, string> map = new()
            { {'S', "Sticks"} , {'s', "Stone"}, {'W', "Wood" }, {'w', "Wool" },
            {'C', "Cobblestone" }, {'D', "Dirt" }, {'d', "Diamond" } };
            return [.. s.Select(x => map[x])];
        }

        private static string[] GenerateRandomExamples()
        {
            string[] arr = new string[100];
            string baseChars = "SsWwCCCCCCDd";
            for (int i = 0; i < 100; i++)
            {
                string inject = "";
                int l = rnd.Next(0, 200);
                for (int j = 0; j < l; j++)
                {
                    char letter = baseChars[rnd.Next(0, 12)];
                    inject += letter;
                }
                arr[i] = inject;
            }
            return arr;
        }
    }
}