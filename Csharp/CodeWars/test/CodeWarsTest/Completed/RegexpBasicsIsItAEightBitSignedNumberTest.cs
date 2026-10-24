using CodeWars.Completed;

namespace CodeWarsTest.Completed
{
    public class RegexpBasicsIsItAEightBitSignedNumberTest
    {
        [Test, Order(1)]
        public void BasicTests()
        {
            using (Assert.EnterMultipleScope())
            {
                Assert.That("".SignedEightBitNumber(), Is.False);
                Assert.That("0".SignedEightBitNumber(), Is.True);
                Assert.That("00".SignedEightBitNumber(), Is.False);
                Assert.That("-0".SignedEightBitNumber(), Is.False);
                Assert.That("55".SignedEightBitNumber(), Is.True);
                Assert.That("-23".SignedEightBitNumber(), Is.True);
                Assert.That("042".SignedEightBitNumber(), Is.False);
                Assert.That("127".SignedEightBitNumber(), Is.True);
                Assert.That("128".SignedEightBitNumber(), Is.False);
                Assert.That("999".SignedEightBitNumber(), Is.False);
                Assert.That("-128".SignedEightBitNumber(), Is.True);
                Assert.That("-129".SignedEightBitNumber(), Is.False);
                Assert.That("-999".SignedEightBitNumber(), Is.False);
                Assert.That("1\n".SignedEightBitNumber(), Is.False);
                Assert.That("1 ".SignedEightBitNumber(), Is.False);
                Assert.That(" 1".SignedEightBitNumber(), Is.False);
                Assert.That("1\n2".SignedEightBitNumber(), Is.False);
                Assert.That("+1".SignedEightBitNumber(), Is.False);
                Assert.That("--1".SignedEightBitNumber(), Is.False);
                Assert.That("11٢".SignedEightBitNumber(), Is.False);
                Assert.That("1٢".SignedEightBitNumber(), Is.False);
                Assert.That("٢".SignedEightBitNumber(), Is.False);
            }
        }

        [Test, Order(2)]
        public void ExtraTests()
        {
            for (int i = -210; i < 210; i++)
            {
                var expected = i >= -128 && i <= 127;
                Assert.That($"{i}".SignedEightBitNumber(), Is.EqualTo(expected));
            }

            for (int i = 0; i < 200; i++)
            {
                using (Assert.EnterMultipleScope())
                {
                    Assert.That($"0{i}".SignedEightBitNumber(), Is.False);
                    Assert.That($"-0{i}".SignedEightBitNumber(), Is.False);
                }
            }
        }
    }
}
