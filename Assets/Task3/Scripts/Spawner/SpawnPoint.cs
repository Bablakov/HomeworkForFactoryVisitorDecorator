using Task3.Interfaces;
using UnityEngine;

namespace Task3.Spawner
{
    public class SpawnPoint : MonoBehaviour
    {
        private ISpawning _spawning;

        public bool IsEmpty => _spawning == null;

        public void Set(ISpawning spawning)
        {
            _spawning = spawning;
            SetPosition();
            Subscribe();
        }

        private void SetPosition()
        {
            _spawning.Transform.position = transform.position;
            _spawning.Transform.rotation = transform.rotation;
        }

        private void Subscribe()
            => _spawning.Destroyed += OnDestroyed;

        private void Unsubscribe()
            => _spawning.Destroyed -= OnDestroyed;

        private void OnDestroyed()
        {
            _spawning = null;
            Unsubscribe();
        }
    }
}