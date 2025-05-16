namespace CodeWars.src.Resolutions
{
    public class HowOldWillIBeIn2099
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            var age = birth - yearTo;
            var year = Math.Abs(age) > 1 ? "years" : "year";

            if (age > 0)
                return $"You will be born in {Math.Abs(age)} {year}.";
            else if (age < 0)
                return $"You are {Math.Abs(age)} {year} old.";
            else
                return "You were born this very year!";
        }
    }
}
