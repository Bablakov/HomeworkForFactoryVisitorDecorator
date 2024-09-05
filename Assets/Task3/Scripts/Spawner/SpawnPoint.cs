using Task3.Interfaces;
using UnityEngine;

namespace Task3.Spawner
{
    public class SpawnPoint : MonoBehaviour
    {
        private IDestroyed _destroyed;

        public bool IsEmpty => _destroyed == null;

        public void Set(IDestroyed spawning)
        {
            _destroyed = spawning;
            SetPosition();
            Subscribe();
        }

        private void SetPosition()
        {
            _destroyed.Transform.position = transform.position;
            _destroyed.Transform.rotation = transform.rotation;
        }

        private void Subscribe()
            => _destroyed.Destroyed += OnDestroyed;

        private void Unsubscribe()
            => _destroyed.Destroyed -= OnDestroyed;

        private void OnDestroyed()
        {
            Unsubscribe();
            _destroyed = null;   
        }
    }
}