namespace CodeWars.src.Resolutions;

public class BuildTower
{
    public static string[] TowerBuilder(int nFloors)
    {
        char space = ' ';
        char asterisk = '*';
        List<string> output = [];
        int quantityAsterisk = 1;

        for (int index = 1; index <= nFloors; index++)
        {
            int blankSpace = nFloors - index;

            string line = new string(space, blankSpace) +
                          new string(asterisk, quantityAsterisk) +
                          new string(space, blankSpace);

            output.Add(line);

            quantityAsterisk += 2;
        }

        return [.. output];
    }
}
