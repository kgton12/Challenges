namespace CodeWars.Completed;

public class CrashOverride
{
    public static string AliasGen(string fName, string lName)
    {
        Dictionary<string, string> FirstName = new Dictionary<string, string>
        {
            { "A", "Alpha" }, { "B", "Beta" }, { "C", "Cool" }, { "D", "Dynamic" },
            { "E", "Epic" }, { "F", "Fearless" }, { "G", "Genius" }, { "H", "Heroic" },
            { "I", "Incredible" }, { "J", "Jolly" }, { "K", "Kind" }, { "L", "Legend" },
            { "M", "Mighty" }, { "N", "Noble" }, { "O", "Outstanding" }, { "P", "Powerful" },
            { "Q", "Quick" }, { "R", "Radical" }, { "S", "Super" }, { "T", "Tough" },
            { "U", "Unique" }, { "V", "Valiant" }, { "W", "Wise" }, { "X", "Xtreme" },
            { "Y", "Young" }, { "Z", "Zesty" }
        };

        Dictionary<string, string> Surname = new Dictionary<string, string>
        {
            { "A", "Adventurer" }, { "B", "Braveheart" }, { "C", "Champion" }, { "D", "Defender" },
            { "E", "Explorer" }, { "F", "Fighter" }, { "G", "Guardian" }, { "H", "Hunter" },
            { "I", "Inventor" }, { "J", "Joker" }, { "K", "Knight" }, { "L", "Leader" },
            { "M", "Master" }, { "N", "Navigator" }, { "O", "Oracle" }, { "P", "Protector" },
            { "Q", "Questor" }, { "R", "Ruler" }, { "S", "Savior" }, { "T", "Traveler" },
            { "U", "Unifier" }, { "V", "Victor" }, { "W", "Warrior" }, { "X", "Xplorer" },
            { "Y", "Yielder" }, { "Z", "Zenith" }
        };

        if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            return "Names cannot be empty.";

        string firstKey = fName[0].ToString().ToUpper();
        string lastKey = lName[0].ToString().ToUpper();

        if (FirstName.TryGetValue(firstKey, out string? alias1) &&
            Surname.TryGetValue(lastKey, out string? alias2))
        {
            return $"{alias1} {alias2}";
        }

        return "Your name must start with a letter from A - Z.";
    }
}