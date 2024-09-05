using System;
using Task3.Interfaces;
using UnityEngine;

namespace Task3.Coins
{
    public abstract class Coin : MonoBehaviour, IDestroyed
    {
        public event Action Destroyed;

        public Transform Transform => transform;

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out ICoinPicker coinPicker))
            {
                AddCoins(coinPicker);

                Destroyed?.Invoke();
                Destroy(gameObject);
            }
        }

        protected abstract void AddCoins(ICoinPicker coinPicker);
    }
}