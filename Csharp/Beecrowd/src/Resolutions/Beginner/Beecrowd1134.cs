namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1134
{
    enum FuelTypeEnum
    {
        Alcohol = 1,
        Gasoline = 2,
        Diesel = 3
    }

    public static void FuelType()
    {
        var fuelCounters = new Dictionary<FuelTypeEnum, int>
        {
            { FuelTypeEnum.Alcohol, 0 },
            { FuelTypeEnum.Gasoline, 0 },
            { FuelTypeEnum.Diesel, 0 }
        };

        while (true)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            if (value == 4) break;

            if (value < 1 || value > 4) continue;

            fuelCounters[(FuelTypeEnum)value]++;
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {fuelCounters[FuelTypeEnum.Alcohol]}");
        Console.WriteLine($"Gasolina: {fuelCounters[FuelTypeEnum.Gasoline]}");
        Console.WriteLine($"Diesel: {fuelCounters[FuelTypeEnum.Diesel]}");
    }
}
