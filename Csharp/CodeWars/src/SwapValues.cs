namespace CodeWars.src
{
    public class Swapper(object[] args)
    {
        public object[] Arguments { get; private set; } = args;

        public void SwapValues() =>
            (Arguments[1], Arguments[0]) = (Arguments[0], Arguments[1]);
    }
}
