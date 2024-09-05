using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Task3.Enums;
using Task3.Factory;
using Random = UnityEngine.Random;

namespace Task3.Spawner
{
    public class CoinSpawner
    {
        private List<SpawnPoint> _spawnPoints;
        private CoinFactory _coinFactory;

        public CoinSpawner(IEnumerable<SpawnPoint> spawnPoints, CoinFactory coinFactory)
        {
            _spawnPoints = new List<SpawnPoint>(spawnPoints);
            _coinFactory = coinFactory;
        }

        public bool CanSpawn => _spawnPoints.Any(spawnPoint => spawnPoint.IsEmpty);

        public void Spawn()
        {
            if (CanSpawn)
            {
                var randomTypeCoin = GetRandomCoinType();
                FindSpawnPoint().Set(_coinFactory.Get(randomTypeCoin));
            }
            else
            {
                Debug.Log("Места переполнены");
            }
        }

        private CoinType GetRandomCoinType()
        {
            int numberEnemyType = Enum.GetValues(typeof(CoinType)).Length;
            int randomNumber = Random.Range(0, numberEnemyType);

            return (CoinType)randomNumber;
        }

        private SpawnPoint FindSpawnPoint()
        {
            var emptyPoints = _spawnPoints.Where(spawnPoint => spawnPoint.IsEmpty);

            var randomPoints = Random.Range(0, emptyPoints.Count());

            return emptyPoints.ElementAt(randomPoints);
        }
    }
}