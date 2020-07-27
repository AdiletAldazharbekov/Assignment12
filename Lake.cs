namespace ConsoleApp1
{
    internal class Lake : ObjectWithLocation
    {
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Depth { get; private set; }

        public Lake(byte x, byte y, int width, int length, int depth) : base(x, y)
        {
            Width = width;
            Length = length;
            Depth = depth;
        }
    }
}