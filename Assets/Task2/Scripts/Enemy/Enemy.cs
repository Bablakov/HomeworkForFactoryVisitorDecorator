using UnityEngine;

namespace Task2.Enemys
{
    public abstract class Enemy : MonoBehaviour
    {
        public void Initialize()
            => Attack();

        public abstract void Attack();
    }
}