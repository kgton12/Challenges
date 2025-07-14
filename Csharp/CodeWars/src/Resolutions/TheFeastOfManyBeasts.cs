namespace CodeWars.src.Resolutions
{
    public class TheFeastOfManyBeasts
    {
        public static bool Feast(string beast, string dish) =>
            GetFirstAndLastLetter(beast) == GetFirstAndLastLetter(dish);

        private static string GetFirstAndLastLetter(string str) =>
            $"{str.First()}{str.Last()}";
    }
}
