using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class ComputeUnixPathTest
{
    [Test]
    public void EmptyTests()
    {
        var expected = CombinePathsUri();
        Assert.That(ComputeUnixPath.CombinePathsUri(), Is.EqualTo(expected));

        expected = CombinePathsUri("/");
        Assert.That(ComputeUnixPath.CombinePathsUri("/"), Is.EqualTo(expected));

        expected = CombinePathsUri("/", "/", "/");
        Assert.That(ComputeUnixPath.CombinePathsUri("/", "/", "/"), Is.EqualTo(expected));

        expected = CombinePathsUri("\\");
        Assert.That(ComputeUnixPath.CombinePathsUri("\\"), Is.EqualTo(expected));

        expected = CombinePathsUri("\\", "\\", "\\");
        Assert.That(ComputeUnixPath.CombinePathsUri("\\", "\\", "\\"), Is.EqualTo(expected));

        expected = CombinePathsUri("/", "\\");
        Assert.That(ComputeUnixPath.CombinePathsUri("/", "\\"), Is.EqualTo(expected));

        expected = CombinePathsUri("/", "\\", "/", "\\", "/", "\\", "/");
        Assert.That(ComputeUnixPath.CombinePathsUri("/", "\\", "/", "\\", "/", "\\", "/"), Is.EqualTo(expected));
    }

    [Test]
    public void SimpleTests()
    {
        var expected = CombinePathsUri("google", "search", "test");
        Assert.That(ComputeUnixPath.CombinePathsUri("google", "search", "test"), Is.EqualTo(expected));

        expected = CombinePathsUri("\\testing\\back\\", "\\slashes\\");
        Assert.That(ComputeUnixPath.CombinePathsUri("\\testing\\back\\", "\\slashes\\"), Is.EqualTo(expected));

        expected = CombinePathsUri("   /testing", "", "", "  \\  empty", "\\parts/", " and ", "", "with/different\\slashes    ");
        Assert.That(ComputeUnixPath.CombinePathsUri("   /testing", "", "", "  \\  empty", "\\parts/", " and ", "", "with/different\\slashes    "), Is.EqualTo(expected));
    }

    [Test]
    public void RandomTests()
    {
        List<String> parameters;
        var random = new Random();
        for (var index = 0; index < 50; index++)
        {
            parameters = [];
            var numberOfParameters = random.Next(4, 10);
            for (var randomIndex = 0; randomIndex < numberOfParameters; randomIndex++)
            {
                parameters.Add(PreloadedStrings[random.Next(0, PreloadedStrings.Count)]);
            }
            var expected = CombinePathsUri([.. parameters]);
            Assert.That(ComputeUnixPath.CombinePathsUri([.. parameters]), Is.EqualTo(expected));
        }
    }

    private static readonly List<String> PreloadedStrings = [
        "    ",
        " / ",
        " / / / / ",
        " \\ ",
        " \\ \\ \\ \\ ",
        "/ \\ /",
        "\\ / \\",
        " . ",
        " .. ",
        "test",
        "custom",
        "part",
        "search",
        "random",
        "./complex",
        "parent\\..\\",
        "/complex/path/with/slashes/inside/",
        "\\complex\\path\\with\\back\\slashes\\inside\\"
      ];

    private static String CombinePathsUri(params String[] PathParts)
    {
        return "/" + PathParts.Where(PathToken => !String.IsNullOrEmpty(PathToken)).Aggregate(
          String.Empty,
          (Current, PathToken) =>
          {
              var currentPart = PathToken.Replace('\\', '/').Trim(' ', '/');
              return String.Concat(
            Current,
            currentPart.Length > 0 ?
              String.Concat(
                Current.Length > 0 ? "/" : String.Empty,
                PathToken.Replace('\\', '/').Trim(' ', '/')
              )
              : String.Empty
          );
          }
        ).TrimEnd('/');
    }
}
