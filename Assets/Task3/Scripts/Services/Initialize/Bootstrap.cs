using Assets.Task3.Scripts.UI;
using System.Collections.Generic;
using Task3.Coins;
using Task3.Factory;
using Task3.Mediator;
using Task3.Spawner;
using UnityEngine;

namespace Task3.Services.Initialize
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private EmptyCoin _emptyCoin;
        [SerializeField] private RandomCoin _randomCoin;
        [SerializeField] private StandartCoin _standartCoin;
        [SerializeField] private List<SpawnPoint> _spawnPoints;
        [SerializeField] private SpawnPanel _spawnPanel;

        private CoinFactory _coinFactory;
        private CoinSpawner _coinSpawner;
        private SpawnMediator _spawnMediator;

        private void Awake()
        {
            _coinFactory = new CoinFactory(_emptyCoin, _randomCoin, _standartCoin);
            _coinSpawner = new CoinSpawner(_spawnPoints, _coinFactory);
            _spawnMediator = new SpawnMediator(_spawnPanel, _coinSpawner);
        }
    }
}