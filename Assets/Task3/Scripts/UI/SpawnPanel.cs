using System;
using UnityEngine;
using UnityEngine.UI;

namespace Task3.UI
{
    public class SpawnPanel : MonoBehaviour
    {
        public event Action SpawnClicked;

        [SerializeField] private Button _buttonSpawn;

        private void OnEnable() => Subscribe();

        private void OnDisable() => Unsubscribe();

        private void Subscribe() => _buttonSpawn.onClick.AddListener(OnSpawnClick);

        private void Unsubscribe() => _buttonSpawn.onClick.RemoveListener(OnSpawnClick);

        private void OnSpawnClick() => SpawnClicked?.Invoke();
    }
}