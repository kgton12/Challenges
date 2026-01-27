namespace CodeWars.Resolutions;

public class CrashOverride
{
    public static string AliasGen(string fName, string lName)
    {
        //values ​​derived from the partial class
        Dictionary<string, string> FirstName = [];
        Dictionary<string, string> Surname = [];

        return char.IsLetter(fName[0]) && char.IsLetter(lName[0])
        ? $"{FirstName[fName[0].ToString()]} {Surname[lName[0].ToString()]}"
        : "Your name must start with a letter from A - Z.";
    }
}
