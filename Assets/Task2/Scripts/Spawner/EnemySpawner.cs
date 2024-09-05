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
        private EnemyFactory _enemyFactory;
        private Transform _spawnPoint;
        private float _rangeSpawne;

        public EnemySpawner(Transform spawnPoint, float rangeSpawn)
        {
            _spawnPoint = spawnPoint;
            _rangeSpawne = rangeSpawn;
        }

        //public EnemyRace EnemyFactoryType { get; private set; }

        public void Spawn()
        {
            EnemyType selectedEnemyType = GetRandomEnemyType();
            Enemy enemy = _enemyFactory.Get(selectedEnemyType);
            enemy.transform.position = CalculateRandomSpawnPoint();
        }

        public void SetEnemySpawner(EnemyFactory enemyFactory) 
            => _enemyFactory = enemyFactory;

        private EnemyType GetRandomEnemyType()
        {
            int numberEnemyType = Enum.GetValues(typeof(EnemyType)).Length;
            int randomNumber = Random.Range(0, numberEnemyType);
            
            return (EnemyType)randomNumber;
        }

        private Vector3 CalculateRandomSpawnPoint()
        {
            float rangeByX = Random.Range(-_rangeSpawne, _rangeSpawne);
            float rangeByZ = Random.Range(-_rangeSpawne, _rangeSpawne);

            Vector3 spawnPoint = new Vector3(_spawnPoint.position.x + rangeByX, 0, _spawnPoint.position.z + rangeByZ);

            return spawnPoint;
        }
    }
}