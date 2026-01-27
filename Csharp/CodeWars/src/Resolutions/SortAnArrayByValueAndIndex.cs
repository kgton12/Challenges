namespace CodeWars.Resolutions;

public class SortAnArrayByValueAndIndex
{
    public static int[] SortByValueAndIndex(int[] array) =>
        [..
            array
            .Select((value, index) => (value, key: value * (index + 1)))
            .OrderBy(tuple => tuple.key)
            .Select(tuple => tuple.value)
        ];
}
