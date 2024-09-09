using System;
using Task2.Enemys;
using Task2.Enums;
using Task2.Factory;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Task2.Spawner
{
    public class EnemySpawner
    {
        private const float DefaultPositionByY = 0;

        private EnemyFactory _enemyFactory;
        private Transform _spawnPoint;
        private float _rangeSpawn;

        public EnemySpawner(Transform spawnPoint, float rangeSpawn)
        {
            _spawnPoint = spawnPoint;
            _rangeSpawn = rangeSpawn;
        }

        private float RandomRangeSpawn => Random.Range(-_rangeSpawn, _rangeSpawn);
        private float PositionByX => _spawnPoint.position.x;
        private float PositionByZ => _spawnPoint.position.z;

        public void Spawn()
        {
            EnemyType selectedEnemyType = GetRandomEnemyType();
            Enemy enemy = _enemyFactory.Get(selectedEnemyType, CalculateRandomSpawnPoint());
            enemy.Initialize();
        }

        public void SetEnemyFactory(EnemyFactory enemyFactory) 
            => _enemyFactory = enemyFactory;

        private EnemyType GetRandomEnemyType()
        {
            int numberEnemyType = Enum.GetValues(typeof(EnemyType)).Length;
            int randomNumber = Random.Range(0, numberEnemyType);
            
            return (EnemyType)randomNumber;
        }

        private Vector3 CalculateRandomSpawnPoint()
            => new Vector3(PositionByX + RandomRangeSpawn, DefaultPositionByY, PositionByZ + RandomRangeSpawn);
    }
}