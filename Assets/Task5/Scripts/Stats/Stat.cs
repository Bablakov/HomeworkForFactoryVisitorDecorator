namespace Task5.Stats
{
    public abstract class Stat
    {
        public Stat(int value)
            => Value = value;

        public int Value { get; private set; }

        public Stat Add(int value)
        {
            Value += value;
            return this;
        }
        public Stat Reduce(int value)
        {
            Value -= value;
            return this;
        }
        public Stat Multiply(int value)
        {
            Value *= value;
            return this;
        }
        public Stat Devide(int value)
        {
            Value /= value;
            return this;
        }
    }
}