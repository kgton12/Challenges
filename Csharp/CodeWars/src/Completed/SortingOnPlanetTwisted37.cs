namespace CodeWars.Completed;

public class SortingOnPlanetTwisted37
{
    public static int[] SortTwisted37(int[] array)
    {
        return [.. array
                .OrderBy(Weight)
                .ThenBy(n => n)];
    }
    private static int Weight(int numero)
    {
        string texto = numero.ToString();

        string transformed = new(
            [.. texto.Select(c => c switch
            {
                '3' => '7',
                '7' => '3',
                _ => c
            })]
        );

        return int.Parse(transformed);
    }
}