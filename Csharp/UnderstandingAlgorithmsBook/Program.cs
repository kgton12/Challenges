namespace UnderstandingAlgorithmsBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 3, 5, 7, 9];
            int target = 11;

            Console.WriteLine(BinarySearch.Search(arr, target));
        }
    }
}