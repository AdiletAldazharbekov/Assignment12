namespace ConsoleApp1
{
    abstract class ObjectWithLocation
    {
        public (byte x, byte y) Location { get; protected set; }

        public ObjectWithLocation(byte x, byte y)
        {
            Location = (x, y);
        }
    }
}