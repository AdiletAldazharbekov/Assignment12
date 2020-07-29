using System;

namespace ConsoleApp1
{
    internal class Bird : MovingObject
    {
        public Tree HomeTree { get; private set; }

        public Bird(byte x, byte y) : base(x, y)
        { }

        public void Nest(Tree tree) => HomeTree = tree;

        public new void Move(byte x, byte y)
        {
            if (Math.Abs(Location.x - x) <= 3 && Math.Abs(Location.y - y) <= 3)
                base.Move(x, y);
        }

        public override void Grow()
        {
            if (Age < 10) base.Grow();
            else Die();
        }
    }
}