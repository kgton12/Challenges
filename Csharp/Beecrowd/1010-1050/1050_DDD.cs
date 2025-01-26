namespace Beecrowd._1010_1050
{
    public class _1050_DDD
    {
        public string DDD(string l)
        {
            string ddd;
            ddd = l;
            string msg;
            switch (ddd)
            {
                case "61":
                    msg = ("Brasilia");
                    break;
                case "71":
                    msg = ("Salvador");
                    break;
                case "11":
                    msg = ("Sao Paulo");
                    break;
                case "21":
                    msg = ("Rio de Janeiro");
                    break;
                case "32":
                    msg = ("Juiz de Fora");
                    break;
                case "19":
                    msg = ("Campinas");
                    break;
                case "27":
                    msg = ("Vitoria");
                    break;
                case "31":
                    msg = ("Belo Horizonte");
                    break;
                default:
                    msg = ("DDD nao cadastrado");
                    break;
            }
            return msg;
        }
    }
}
