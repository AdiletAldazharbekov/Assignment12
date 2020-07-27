using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class MovingObject : LivingObject
    {
        public MovingObject(byte x, byte y) : base(x, y)
        { }

        public void Move(byte x, byte y)
        {
            if (Alive) Location = (x, y);
        }
    }
}