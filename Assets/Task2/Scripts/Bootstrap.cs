using Task2.Enemys.RaceType.Elf;
using Task2.Enemys.RaceType.Ork;
using Task2.Factory;
using Task2.Spawner;
using UnityEngine;

namespace Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPointFirstSpawner;
        [SerializeField] private Transform _spawnPointSecondSpawner;
        [SerializeField, Range(0, 10)] private float _rangeSpawn;

        private EnemySpawner _firstEnemySpawner;
        private EnemySpawner _secondEnemySpawner;

        private ElfFactory _elfFactory;
        private OrkFactory _orkFactory;

        private bool _isFirstEnemySpawnerWithElfFactory;

        private void Awake()
        {
            _firstEnemySpawner = new EnemySpawner(_spawnPointFirstSpawner, _rangeSpawn);
            _secondEnemySpawner = new EnemySpawner(_spawnPointSecondSpawner, _rangeSpawn);

            _firstEnemySpawner.SetEnemySpawner(_elfFactory);
            _secondEnemySpawner.SetEnemySpawner(_orkFactory);

            _isFirstEnemySpawnerWithElfFactory = true;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _firstEnemySpawner.Spawn();
                _secondEnemySpawner.Spawn();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (_isFirstEnemySpawnerWithElfFactory)
                {
                    _firstEnemySpawner.SetEnemySpawner(_orkFactory);
                    _secondEnemySpawner.SetEnemySpawner(_elfFactory);

                    _isFirstEnemySpawnerWithElfFactory = false;
                }

                else
                {
                    _firstEnemySpawner.SetEnemySpawner(_elfFactory);
                    _secondEnemySpawner.SetEnemySpawner(_orkFactory);

                    _isFirstEnemySpawnerWithElfFactory = true;
                }
            }
        }
    }
}