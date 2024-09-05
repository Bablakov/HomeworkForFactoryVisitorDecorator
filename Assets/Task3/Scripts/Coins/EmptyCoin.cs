using Task3.Interfaces;

namespace Task3.Coins
{
    public class EmptyCoin : Coin
    {
        protected override void AddCoins(ICoinPicker coinPicker) { }
    }
}