namespace BeeCrowd.src.Resolutions.String
{
    public class Beecrowd3358
    {
        public static void LastNameIsNotEasy()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string lineValue = Console.ReadLine() ?? string.Empty;

                Console.WriteLine(ThreeConsecutiveConsonants(lineValue) ?
                $"{lineValue} nao eh facil" :
                $"{lineValue} eh facil");
            }
        }

        private static bool ThreeConsecutiveConsonants(string lastName)
        {
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };

            int quantity = 0;

            foreach (var c in lastName)
            {
                if (char.IsLetter(c) && !vowel.Contains(char.ToLower(c)))
                    quantity++;
                else
                    quantity = 0;

                if (quantity == 3) return true;
            }

            return false;
        }
    }
}