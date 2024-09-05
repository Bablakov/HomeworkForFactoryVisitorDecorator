using System;
using Task3.Coins;
using Task3.Enums;
using UnityEngine;

namespace Task3.Factory
{
    public class CoinFactory
    {
        private EmptyCoin _emptyCoin;
        private RandomCoin _randomCoin;
        private StandartCoin _standartCoin;

        public CoinFactory(EmptyCoin emptyCoin, RandomCoin randomCoin, StandartCoin standartCoin)
        {
            _emptyCoin = emptyCoin;
            _randomCoin = randomCoin;
            _standartCoin = standartCoin;
        }

        public Coin Get(CoinType coinType)
        {
            switch (coinType)
            {
                case CoinType.EmtyCoin:
                    return GameObject.Instantiate(_emptyCoin);

                case CoinType.RandomCoin:
                    return GameObject.Instantiate(_randomCoin);

                case CoinType.StandartCoin:
                    return GameObject.Instantiate(_standartCoin);

                default:
                    throw new ArgumentException(nameof(coinType));
            }
        }
    }
}