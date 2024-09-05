using Task2.Enemys.RaceType.Elf;
using Task2.Enemys.RaceType.Ork;
using Task2.Spawner;
using Task2.Factory;
using UnityEngine;
using Zenject;

namespace Task2.Zenject
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private Transform _spawnPointFirstSpawner;
        [SerializeField] private Transform _spawnPointSecondSpawner;

        public override void InstallBindings()
        {
            /*_elfFactory = new ElfFactory(_elfPaladin, _elfMagician);
            _orkFactory = new OrkFactory(_orkPaladin, _orkMagician);

            _firstEnemySpawner = new EnemySpawner(_spawnPointFirstSpawner, _rangeSpawn);
            _secondEnemySpawner = new EnemySpawner(_spawnPointSecondSpawner, _rangeSpawn);

            _firstEnemySpawner.SetEnemySpawner(_elfFactory);
            _secondEnemySpawner.SetEnemySpawner(_orkFactory);

            Container.BindInterfacesAndSelfTo<Enem>()*/
        }

        /*private void BindPlayer()
        {
            Container.BindInterfacesAndSelfTo<Level>().AsSingle();
            Container.BindInterfacesAndSelfTo<Health>().AsSingle();
            Container.BindInterfacesAndSelfTo<Player>().AsSingle();
        }

        private void BindMonoBehaviourComponent()
        {
            Container.BindInterfacesAndSelfTo<SpecificationPanel>().FromInstance(_specificationPanel);
            Container.BindInterfacesAndSelfTo<InteractionPanel>().FromInstance(_interactionPanel);
            Container.BindInterfacesAndSelfTo<DefeatPanel>().FromInstance(_defeatPanel);
        }

        private void BindMediators()
        {
            Container.BindInterfacesAndSelfTo<SpecificationPlayerMediator>().AsSingle();
            Container.BindInterfacesAndSelfTo<InteractionPlayerMediator>().AsSingle();
            Container.BindInterfacesAndSelfTo<DefeatMediator>().AsSingle();
        }
    }*/
    }
}