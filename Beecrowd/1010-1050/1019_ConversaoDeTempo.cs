
namespace Beecrowd
{
    public class _1019_ConversaoDeTempo
    {
        public string ConversaoDeTempo(string s)
        {
            int segundos = int.Parse(s);

            int hor = (int)(segundos / (60 * 60));

            int min = (int)((segundos - (hor * 60 * 60)) / 60);

            int seg = (int)(segundos - (hor * 60 * 60) - (min * 60));

            return ($"{hor}:{min}:{seg}");
        }
    }
}
