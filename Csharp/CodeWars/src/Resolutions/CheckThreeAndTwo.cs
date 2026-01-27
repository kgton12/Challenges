namespace CodeWars.Resolutions
{
    public class CheckThreeAndTwoClass
    {
        public static bool CheckThreeAndTwo(string[] array)
        {
            var groupedValues = array.GroupBy(g => g).Select(s => s.Count());

            bool hasCount2 = groupedValues.Any(x => x == 2);
            bool hasCount3 = groupedValues.Any(x => x == 3);

            return hasCount2 && hasCount3;
        }
    }
}
