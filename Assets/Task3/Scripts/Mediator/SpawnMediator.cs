using Task3.UI;
using System;
using Task3.Spawner;

namespace Task3.Mediator
{
    public class SpawnMediator : IDisposable
    {
        private SpawnPanel _spawnPanel;
        private CoinSpawner _coinSpawner;

        public SpawnMediator(SpawnPanel spawnPanel, CoinSpawner coinSpawner)
        {
            _spawnPanel = spawnPanel;
            _coinSpawner = coinSpawner;
            Subscribe();
        }

        public void Dispose()
            => Unsubscribe();

        private void Subscribe()
            => _spawnPanel.SpawnClicked += OnSpawnClicked;

        private void Unsubscribe()
            => _spawnPanel.SpawnClicked -= OnSpawnClicked;

        private void OnSpawnClicked() => _coinSpawner.Spawn();
    }
}