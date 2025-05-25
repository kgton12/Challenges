namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1114
{
    public static void FixedPassword()
    {
        while (true)
        {
            string validPassword = "2002";

            string inputPassword = Console.ReadLine() ?? string.Empty;

            if (inputPassword == validPassword)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
                Console.WriteLine("Senha Invalida");
        }
    }
}
