using Task2.Configs;
using Task2.Enemys.RaceType.Elf;
using Task2.Enemys.RaceType.Ork;
using Task2.Factory;
using Task2.Mediator;
using Task2.Spawner;
using Task2.UI;
using UnityEngine;

namespace Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPointFirstSpawner;
        [SerializeField] private Transform _spawnPointSecondSpawner;
        [SerializeField] private ControlPanel _controlPanel;
        [SerializeField, Range(0, 10)] private float _rangeSpawn;
        [SerializeField] private EnemyConfig _enemyConfig;

        private EnemySpawner _firstEnemySpawner;
        private EnemySpawner _secondEnemySpawner;
        private SpawnerController _spawnerController;
        private ControlMediator _controlMediator;

        private ElfFactory _elfFactory;
        private OrkFactory _orkFactory;

        private void Awake()
        {
            _firstEnemySpawner = new EnemySpawner(_spawnPointFirstSpawner, _rangeSpawn);
            _secondEnemySpawner = new EnemySpawner(_spawnPointSecondSpawner, _rangeSpawn);

            _elfFactory = new ElfFactory(_enemyConfig.ElfPaladin, _enemyConfig.ElfMagician);
            _orkFactory = new OrkFactory(_enemyConfig.OrkPaladin, _enemyConfig.OrkMagician);

            _spawnerController = new SpawnerController(_firstEnemySpawner, _secondEnemySpawner, _elfFactory, _orkFactory);

            _controlMediator = new ControlMediator(_spawnerController, _controlPanel);
        }
    }
}