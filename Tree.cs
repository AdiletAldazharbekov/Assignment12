namespace ConsoleApp1
{
    class Tree : LivingObject
    {
        public int Height { get; private set; }

        public Tree(byte x, byte y, int height) : base(x, y)
        {
            Height = height;
        }
    }
}