namespace CodeWars.Resolutions
{
    public static class EvenOrOddWhichIsGreater
    {
        public static string EvenOrOdd(string str)
        {
            int sumOdd = 0;
            int sumEven = 0;

            foreach (var ch in str)
            {
                int value = (int)char.GetNumericValue(ch);
                if (value % 2 == 0)
                    sumEven += value;
                else
                    sumOdd += value;
            }

            if (sumEven > sumOdd) return "Even is greater than Odd";
            else if (sumOdd > sumEven) return "Odd is greater than Even";
            else return "Even and Odd are the same";
        }
    }
}