namespace CodeWars.Completed;

public class FilePathOperations(string filepath)
{
    private readonly string _filepath = filepath;

    public string Extension()
    {
        return _filepath
               .Split('/')
               .Last()
               .Split('.')
               .Last();
    }
    public string Filename()
    {
        return _filepath
               .Split('/')
               .Last()
               .Split('.')
               .First();
    }
    public string Dirpath()
    {
        return string.Join('/', _filepath
                   .Split('/')
                   .SkipLast(1)
               ) + "/";
    }
}