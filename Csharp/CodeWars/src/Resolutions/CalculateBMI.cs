namespace CodeWars.Resolutions;

public class CalculateBMI
{
    public static string Bmi(double weight, double height)
    {
        double bmi = weight / (height * height);

        return bmi switch
        {
            <= 18.5 => "Underweight",
            <= 25.0 => "Normal",
            <= 30.0 => "Overweight",
            _ => "Obese"
        };
    }
}
