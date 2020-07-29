namespace Assignment12
{
    internal abstract class MovingObject : LivingObject
    {
        public MovingObject(byte x, byte y) : base(x, y)
        { }

        public void Move(byte x, byte y)
        {
            if (Alive) Location = (x, y);
        }
    }
}