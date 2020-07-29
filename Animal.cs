using System;

namespace ConsoleApp1
{
    internal class Animal : MovingObject
    {
        public Animal(byte x, byte y) : base(x, y)
        { }

        public new void Move(byte x, byte y)
        {
            if (Math.Abs(Location.x - x) <= 1 && Math.Abs(Location.y - y) <= 1)
                base.Move(x, y);
        }

        public override void Grow()
        {
            if (Age < 10) base.Grow();
            else Die();
        }
    }
}