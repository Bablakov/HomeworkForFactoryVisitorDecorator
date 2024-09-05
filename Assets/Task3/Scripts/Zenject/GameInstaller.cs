using Task3.UI;
using System.Collections.Generic;
using Task3.Factory;
using Task3.Input;
using Task3.Mediator;
using Task3.Spawner;
using UnityEngine;
using Zenject;

namespace Task3.Zenject
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private List<SpawnPoint> _spawnPoints;
        [SerializeField] private SpawnPanel _spawnPanel;
        [SerializeField] private Player _player;

        public override void InstallBindings()
        {
            BindInputSystem();
            BindPlayer();
            BindCoinFactory();
            BindCoinSpawner();
            BindSpawnMediator();
        }

        private void BindInputSystem()
            => Container.BindInterfacesAndSelfTo<GameInput>().AsSingle();

        private void BindPlayer()
            => Container.BindInterfacesAndSelfTo<Player>().FromInstance(_player);

        private void BindCoinFactory()
            => Container.BindInterfacesAndSelfTo<CoinFactory>().AsSingle();

        private void BindCoinSpawner()
            => Container.BindInterfacesAndSelfTo<CoinSpawner>().AsSingle().WithArguments(_spawnPoints);

        private void BindSpawnMediator()
            => Container.BindInterfacesAndSelfTo<SpawnMediator>().AsSingle().WithArguments(_spawnPanel);
    }
}
