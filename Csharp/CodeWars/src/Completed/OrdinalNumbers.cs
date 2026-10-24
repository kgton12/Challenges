namespace CodeWars.Completed;

public class OrdinalNumbers
{
    public static string Ordinal(int number, bool brief = false)
    {
        int valor = Math.Abs(number);
        int ultimosDoisDigitos = valor % 100;

        string sufixo = ultimosDoisDigitos switch
        {
            11 or 12 or 13 => "th",

            _ => (valor % 10) switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            }
        };

        return brief && sufixo.Contains('d')
            ? "d"
            : sufixo;
    }
}