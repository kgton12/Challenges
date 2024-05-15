
namespace Beecrowd._1051_1099
{
    public class _1064_PositivoseMedia
    {
        public string PositivoseMedia(double[] l)
        {
            string msg = "";

            double x = 0, media = 0, cont = 0;
            double[] vetor = l;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > 0.0)
                {
                    x = x + vetor[i];
                    cont++;
                    media = (double)x / cont;
                }
            }

            msg += string.Format("{0} valores positivos\r\n", cont);
            msg += string.Format("{0:f1}", media);

            Console.WriteLine(msg);

            return "";
        }
    }
}
