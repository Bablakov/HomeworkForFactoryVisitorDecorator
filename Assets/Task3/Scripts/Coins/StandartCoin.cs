using Task3.Interfaces;
using UnityEngine;

namespace Task3.Coins
{
    public class StandartCoin : Coin
    {
        [SerializeField, Range(0, 50)] private int _value;

        protected override void AddCoins(ICoinPicker coinPicker) => coinPicker.Add(_value);
    }
}