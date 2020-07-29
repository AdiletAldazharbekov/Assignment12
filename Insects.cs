using System;

namespace Assignment12
{
    internal class Insects : MovingObject
    {
        public Insects(byte x, byte y) : base(x, y)
        { }

        public new void Move(byte x, byte y)
        {
            if (Math.Abs(Location.x - x) <= 1 && Math.Abs(Location.y - y) <= 1)
                base.Move(x, y);
        }

        public override void Grow()
        {
            if (Age < 2) base.Grow();
            else Die();
        }
    }
}