using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Stone : ObjectWithLocation
    {
        public int Weight { get; private set; }

        public Stone(int weight, byte x, byte y) : base(x, y)
        {
            Weight = weight;
        }
    }
}