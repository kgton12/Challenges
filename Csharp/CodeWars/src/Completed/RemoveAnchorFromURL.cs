namespace CodeWars.Completed;

public class RemoveAnchorFromURL
{
    public static string RemoveUrlAnchor(string url)
    {
        int indexAnchor = url.IndexOf('#');

        return indexAnchor >= 0 ? url[..indexAnchor] : url;
    }
}
