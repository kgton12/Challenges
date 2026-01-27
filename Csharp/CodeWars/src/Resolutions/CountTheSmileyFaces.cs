namespace CodeWars.Resolutions;

public class CountTheSmileyFaces
{
    public static int CountSmileys(string[] smileys)
    {
        string[] validSmileys = [":-D", ":-)", ":~)", ":~D", ";-D", ";-)", ";~)", ";~D", ":D", ":)", ";D", ";)"];

        return validSmileys.Sum(s => smileys.Count(c => s.Equals(c)));
    }
}
