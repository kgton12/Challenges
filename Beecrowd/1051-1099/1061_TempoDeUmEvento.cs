using System.Text.RegularExpressions;

namespace Beecrowd._1051_1099
{
    public class _1061_TempoDeUmEvento
    {
        public string TempoDeUmEvento(string[] l)
        {
            //string[] linha = new string[4];

            int total_dias;
            int total_horas;
            int total_minutos;
            int total_segundos;

            //linha[0] = Console.ReadLine();
            //linha[1] = Console.ReadLine();
            //linha[2] = Console.ReadLine();
            //linha[3] = Console.ReadLine();
            string[] linha = l;

            int diaInicial = int.Parse(Regex.Replace(linha[0], "[^0-9]", ""));
            string[] horaInicial = linha[1].Replace(" ", "").Split(':');

            int diaFinal = int.Parse(Regex.Replace(linha[2], "[^0-9]", ""));
            string[] horaFinal = linha[3].Replace(" ", "").Split(':');

            total_dias = diaFinal - diaInicial;
            total_horas = int.Parse(horaFinal[0]) - (int.Parse(horaInicial[0]));
            total_minutos = int.Parse(horaFinal[1]) - (int.Parse(horaInicial[1]));
            total_segundos = int.Parse(horaFinal[2]) - (int.Parse(horaInicial[2]));

            if (total_horas < 0)
            {
                total_horas += 24;
                total_dias -= 1;
            }
            if (total_minutos < 0)
            {
                total_minutos += 60;
                total_horas -= 1;
            }
            if (total_segundos < 0)
            {
                total_segundos += 60;
                total_minutos -= 1;
            }

            string msg = $"{total_dias} dia(s) \n\r{total_horas} hora(s)\n\r{total_minutos} minuto(s)\n\r{total_segundos} segundos(s)";

            Console.WriteLine(msg);

            return msg;
        }
    }
}
