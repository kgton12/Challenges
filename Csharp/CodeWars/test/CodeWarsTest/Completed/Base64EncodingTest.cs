using CodeWars.Completed;
using System.Text;

namespace CodeWarsTest.Completed;

public class Base64EncodingTest
{
    private static readonly (byte[], string)[] Tests = [
          (Encoding.UTF8.GetBytes("this is a bytestring!"), "dGhpcyBpcyBhIGJ5dGVzdHJpbmch"),
      ([], ""),
      ([0], "AA"),
      ([0, 1], "AAE"),
      (Encoding.UTF8.GetBytes("this is a test!"), "dGhpcyBpcyBhIHRlc3Qh"),
      (
        Encoding.UTF8.GetBytes("now is the time for all good men to come to the aid of their country."),
        "bm93IGlzIHRoZSB0aW1lIGZvciBhbGwgZ29vZCBtZW4gdG8gY29tZSB0byB0aGUgYWlkIG9mIHRoZWlyIGNvdW50cnku"
      ),
      (Encoding.UTF8.GetBytes("1234567890"), "MTIzNDU2Nzg5MA"),
      (Encoding.UTF8.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZ "), "QUJDREVGR0hJSktMTU5PUFFSU1RVVldYWVog"),
      (
        Encoding.UTF8.GetBytes("the quick brown fox jumps over the white fence. "),
        "dGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSB3aGl0ZSBmZW5jZS4g"
      ),
      (
        Encoding.UTF8.GetBytes("dGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSB3aGl0ZSBmZW5jZS4"),
        "ZEdobElIRjFhV05ySUdKeWIzZHVJR1p2ZUNCcWRXMXdjeUJ2ZG1WeUlIUm9aU0IzYUdsMFpTQm1aVzVqWlM0"
      ),
      (Encoding.UTF8.GetBytes("VFZSSmVrNUVWVEpPZW1jMVRVTkJaeUFna"), "VkZaU1NtVnJOVVZXVkVwUFpXMWpNVlJWVGtKYWVVRm5h"),
      (Encoding.UTF8.GetBytes("TVRJek5EVTJOemc1TUNBZyAg"), "VFZSSmVrNUVWVEpPZW1jMVRVTkJaeUFn"),
      (
        [
          0xf0, 0x9f, 0x91, 0xa8, 0xf0, 0x9f, 0x8f, 0xbb, 0xe2, 0x80, 0x8d, 0xe2,
          0x9d, 0xa4, 0xef, 0xb8, 0x8f, 0xe2, 0x80, 0x8d, 0xf0, 0x9f, 0x92, 0x8b,
          0xe2, 0x80, 0x8d, 0xf0, 0x9f, 0x91, 0xa8, 0xf0, 0x9f, 0x8f, 0xbb,
        ],
        "8J+RqPCfj7vigI3inaTvuI/igI3wn5KL4oCN8J+RqPCfj7s"
      ),
    ];

    public static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            for (var i = 0; i < Tests.Length; i++)
            {
                var testCase = new TestCaseData(Tests[i].Item1, Tests[i].Item2);
                testCase.SetDescription($"should encode and decode base64 test {i + 1} correctly");
                yield return testCase;
            }
        }
    }

    [TestCaseSource(nameof(TestCases))]
    public void EncodeDecodeTest(byte[] decoded, string encoded)
    {
        //TestContext.Out.WriteLine("Encoding [{0}]", string.Join(", ", decoded));
        //Assert.That(Base64Encoding.ToBase64(decoded), Is.EqualTo(encoded));
        TestContext.Out.WriteLine($"Decoding {encoded}");
        Assert.That(Base64Encoding.FromBase64(encoded), Is.EqualTo(decoded));
    }
}