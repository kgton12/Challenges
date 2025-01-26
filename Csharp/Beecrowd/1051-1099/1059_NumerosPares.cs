namespace Beecrowd._1051_1099
{
    public class _1059_NumerosPares
    {
        public string NumerosPares()
        {
            string msg = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    msg += i.ToString() + "\n\r";
                }
            }
            return msg;
        }
    }
}
