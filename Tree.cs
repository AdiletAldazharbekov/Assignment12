namespace ConsoleApp1
{
    internal class Tree : LivingObject
    {
        public int Height { get; private set; }

        public Tree(byte x, byte y, int height) : base(x, y)
        {
            Height = height;
        }
    }
}