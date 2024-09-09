namespace Task5.Stats
{
    public abstract class Stat
    {
        public Stat(int value)
            => Value = value;

        public int Value { get; private set; }

        public void Add(int value) => Value += value;
        public void Reduce(int value) => Value -= value;
        public void Multiply(int value) => Value *= value;
        public void Devide(int value) => Value /= value;
    }
}