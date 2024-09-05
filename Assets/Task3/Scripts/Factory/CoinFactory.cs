using System;
using Task3.Coins;
using Task3.Configs;
using Task3.Enums;
using UnityEngine;

namespace Task3.Factory
{
    public class CoinFactory
    {
        private CoinConfig _coinCofig;

        public CoinFactory(CoinConfig coinConfig)
            => _coinCofig = coinConfig;

        public Coin Get(CoinType coinType)
            => GameObject.Instantiate(GetCoinType(coinType));

        private Coin GetCoinType(CoinType coinType)
        {
            switch (coinType)
            {
                case CoinType.EmtyCoin:
                    return _coinCofig.EmptyCoin;

                case CoinType.RandomCoin:
                    return _coinCofig.RandomCoin;

                case CoinType.StandartCoin:
                    return _coinCofig.StandartCoin;

                default:
                    throw new ArgumentException(nameof(coinType));
            }
        }
    }
}