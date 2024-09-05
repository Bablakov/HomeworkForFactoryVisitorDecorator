using System;
using Task2.UI;

namespace Task2.Mediator
{
    public class ControlMediator : IDisposable
    {
        private ControlPanel _controlPanel;
        private SpawnerController _spawnerController;

        public ControlMediator(SpawnerController spawnerController, ControlPanel controlPanel)
        {
            _controlPanel = controlPanel;
            _spawnerController = spawnerController;

            Subscribe();
        }

        public void Dispose() => Unsubscribe();

        private void Subscribe()
        {
            _controlPanel.SpawnClicked += OnSpawnClicked;
            _controlPanel.SwitchClicked += OnSwitchClicked;
        }

        private void Unsubscribe() 
        {
            _controlPanel.SpawnClicked -= OnSpawnClicked;
            _controlPanel.SwitchClicked -= OnSwitchClicked;
        }

        private void OnSpawnClicked() => _spawnerController.Spawn();

        private void OnSwitchClicked() => _spawnerController.SwitchFactory();
    }
}