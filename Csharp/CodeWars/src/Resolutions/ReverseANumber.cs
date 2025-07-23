namespace CodeWars.src.Resolutions;

public class ReverseANumber
{
    public static int ReverseNumber(int n) =>
        n.ToString().StartsWith('-') ?
            Convert.ToInt32("-" +
                string.Concat(
                    n.ToString()
                    .Skip(1)
                    .Reverse()
                )
            ) :
            Convert.ToInt32(string.Concat(n.ToString().Reverse()));
}
