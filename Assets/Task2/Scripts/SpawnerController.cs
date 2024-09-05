using Assets.Task2.Scripts.Factory;
using Task2.Factory;
using Task2.Spawner;

namespace Task2
{
    public class SpawnerController
    {
        private EnemySpawner _firstEnemySpawner;
        private EnemySpawner _secondEnemySpawner;

        private FactoryEnemyFactory _factoryEnemyFactory;

        private ElfFactory _elfFactory;
        private OrkFactory _orkFactory;

        private bool _isFirstEnemySpawnerWithElfFactory;

        public SpawnerController(EnemySpawner firstEnemySpawner, EnemySpawner secondEnemySpawner, ElfFactory elfFactory, OrkFactory orkFactory) 
        { 
            _firstEnemySpawner = firstEnemySpawner;
            _secondEnemySpawner = secondEnemySpawner;
            
            _elfFactory = elfFactory;
            _orkFactory = orkFactory;

            _firstEnemySpawner.SetEnemySpawner(_elfFactory);
            _secondEnemySpawner.SetEnemySpawner(_orkFactory);

            _isFirstEnemySpawnerWithElfFactory = true;
        }

        public void Spawn()
        {
            _firstEnemySpawner.Spawn();
            _secondEnemySpawner.Spawn();
        }

        public void SwitchFactory()
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