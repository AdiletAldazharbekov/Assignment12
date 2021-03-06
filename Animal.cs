﻿using System;

namespace Assignment12
{
    internal class Animal : MovingObject
    {
        public Animal(byte x, byte y) : base(x, y)
        { }

        public new void Move(byte x, byte y)
        {
            if (Math.Abs(Location.x - x) <= 2 && Math.Abs(Location.y - y) <= 2)
                base.Move(x, y);
        }

        public override void Grow()
        {
            if (Age < 10) base.Grow();
            else Die();
        }
    }
}