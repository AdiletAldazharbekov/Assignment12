namespace Assignment12
{
    internal abstract class LivingObject : ObjectWithLocation
    {
        public bool Alive { get; private set; } = true;
        public int Age { get; private set; } = 0;

        public LivingObject(byte x, byte y) : base(x, y)
        { }

        public virtual void Grow() => Age += Alive ? 1 : 0;

        public void Die() => Alive = false;
    }
}