namespace Task3.Interfaces
{
    public interface ICoinPicker 
    {
        int Coins { get; }
        void Add(int value);
    }
}