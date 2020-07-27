namespace ConsoleApp1
{
    class Bird : MovingObject
    {
        public Tree HomeTree { get; private set; }

        public Bird(byte x, byte y) : base(x, y)
        { }

        public void Nest(Tree tree) => HomeTree = tree;

        public override void Grow()
        {
            if (Age < 5) base.Grow();
            else Die();
        }
    }
}