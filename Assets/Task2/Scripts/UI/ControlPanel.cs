using System;
using UnityEngine;
using UnityEngine.UI;

namespace Task2.UI
{
    public class ControlPanel : MonoBehaviour
    {
        public event Action SpawnClicked;
        public event Action SwitchClicked;

        [SerializeField] private Button _buttonSpawn;
        [SerializeField] private Button _buttonSwitch;

        private void OnEnable() => Subscribe();

        private void OnDisable() => Unsubscribe();

        private void Subscribe()
        {
            _buttonSpawn.onClick.AddListener(OnSpawnClick);
            _buttonSwitch.onClick.AddListener(OnSwitchClick);
        }

        private void Unsubscribe()
        {
            _buttonSpawn.onClick.RemoveListener(OnSpawnClick);
            _buttonSwitch.onClick.RemoveListener(OnSwitchClick);
        }

        private void OnSpawnClick() => SpawnClicked?.Invoke();

        private void OnSwitchClick() => SwitchClicked?.Invoke();
    }
}