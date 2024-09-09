using Task2.Spawner;
using Task2.Factory;
using UnityEngine;
using Zenject;
using Task2.Mediator;
using Task2.UI;

namespace Task2.Zenject
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private Transform _spawnPointFirstSpawner;
        [SerializeField] private Transform _spawnPointSecondSpawner;
        [SerializeField] private ControlPanel _controlPanel;
        [SerializeField, Range(0, 10)] private float _rangeSpawn;

        private EnemySpawner _firstEnemySpawner;
        private EnemySpawner _secondEnemySpawner;

        public override void InstallBindings()
        {
            BindFactories();
            CreateSpawners();
            BindSpawnerController();
            BindControlMediator();
        }

        private void BindFactories()
        {
            Container.BindInterfacesAndSelfTo<ElfFactory>().AsSingle();
            Container.BindInterfacesAndSelfTo<OrkFactory>().AsSingle();
        }

        private void CreateSpawners()
        {
            _firstEnemySpawner = new EnemySpawner(_spawnPointFirstSpawner, _rangeSpawn);
            _secondEnemySpawner = new EnemySpawner(_spawnPointSecondSpawner, _rangeSpawn);
        }

        private void BindSpawnerController()
            => Container.BindInterfacesAndSelfTo<SpawnerController>().AsSingle().WithArguments(_firstEnemySpawner, _secondEnemySpawner);

        private void BindControlMediator()
            => Container.BindInterfacesAndSelfTo<ControlMediator>().AsSingle().WithArguments(_controlPanel);
    }
}