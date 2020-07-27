namespace ConsoleApp1
{
    internal class Stone : ObjectWithLocation
    {
        public int Weight { get; private set; }

        public Stone(int weight, byte x, byte y) : base(x, y)
        {
            Weight = weight;
        }
    }
}