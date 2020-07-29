namespace Assignment12
{
    internal class Tree : LivingObject
    {
        public int Height { get; private set; }

        public Tree(byte x, byte y, int height) : base(x, y)
        {
            Height = height;
        }

        public override void Grow()
        {
            if (Age < 20) base.Grow();
            else Die();
        }
    }
}