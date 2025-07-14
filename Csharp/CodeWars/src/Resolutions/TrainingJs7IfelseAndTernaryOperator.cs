namespace CodeWars.src.Resolutions;

public class TrainingJs7IfelseAndTernaryOperator
{
    public static int SaleHotDogs(int n) =>
        n < 5 ? n * 100 : n >= 5 && n < 10 ? n * 95 : n * 90;
}
