using UnityEngine;
using Task2.Factory;
using Task2.Spawner;

namespace Task2
{
    public class SpawnerController
    {
        private EnemySpawner _firstEnemySpawner;
        private EnemySpawner _secondEnemySpawner;

        private ElfFactory _elfFactory;
        private OrkFactory _orkFactory;

        private bool _isFirstEnemySpawnerWithElfFactory;

        public SpawnerController(EnemySpawner firstEnemySpawner, EnemySpawner secondEnemySpawner, ElfFactory elfFactory, OrkFactory orkFactory) 
        { 
            _firstEnemySpawner = firstEnemySpawner;
            _secondEnemySpawner = secondEnemySpawner;
            
            _elfFactory = elfFactory;
            _orkFactory = orkFactory;

            _firstEnemySpawner.SetEnemyFactory(_elfFactory);
            _secondEnemySpawner.SetEnemyFactory(_orkFactory);

            _isFirstEnemySpawnerWithElfFactory = true;
        }

        public void Spawn()
        {
            Debug.Log("-----Заспавнились враги-----");
            _firstEnemySpawner.Spawn();
            _secondEnemySpawner.Spawn();
        }

        public void SwitchFactory()
        {
            Debug.Log("-----Смена спавнеров сторонами-----");

            if (_isFirstEnemySpawnerWithElfFactory)
            {
                _firstEnemySpawner.SetEnemyFactory(_orkFactory);
                _secondEnemySpawner.SetEnemyFactory(_elfFactory);

                _isFirstEnemySpawnerWithElfFactory = false;
            }

            else
            {
                _firstEnemySpawner.SetEnemyFactory(_elfFactory);
                _secondEnemySpawner.SetEnemyFactory(_orkFactory);

                _isFirstEnemySpawnerWithElfFactory = true;
            }
        }
    }
}