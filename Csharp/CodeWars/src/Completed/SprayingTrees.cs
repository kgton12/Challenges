namespace CodeWars.Completed
{
    public class SprayingTrees
    {
        private static readonly Dictionary<string, string> workers =
            new()
            {
                {"Monday", "James"},
                {"Tuesday", "John"},
                {"Wednesday", "Robert"},
                {"Thursday", "Michael"},
                {"Friday", "William"}
            };

        public static string Task(string w, int n, int c) =>
            $"It is {w} today, {workers[w]}, you have to work, you must spray {n} trees and you need {n * c} dollars to buy liquid";
    }
}