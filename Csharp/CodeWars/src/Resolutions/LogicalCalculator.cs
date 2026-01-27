namespace CodeWars.Resolutions
{
    public class LogicalCalculator
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            return op switch
            {
                "AND" => array.All(x => x),
                "OR" => array.Any(x => x),
                "XOR" => array.Aggregate((acc, val) => acc ^ val),
                _ => throw new ArgumentException("Operador inválido. Use 'AND', 'OR' ou 'XOR'.", nameof(op))
            };
        }
    }
}
