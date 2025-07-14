namespace CodeWars.src.Resolutions
{
    internal class HexToDecimal
    {
        public static int HexToDec(string hexString)
        {
            bool isNegative = hexString.StartsWith('-');
            string hex = isNegative ? hexString[1..] : hexString;

            int value = Convert.ToInt32(hex, 16);
            return isNegative ? -value : value;
        }
    }
}
