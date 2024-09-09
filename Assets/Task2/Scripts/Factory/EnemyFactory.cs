using UnityEngine;
using Task2.Enemys;
using Task2.Enums;

namespace Task2.Factory
{
    public abstract class EnemyFactory
    {
        public abstract Enemy Get(EnemyType enemyType, Vector3 spawnPosition);

        protected Enemy CreateEnemy(Enemy enemy, Vector3 SpawnPosition)
        {
            var instantiateEnemy = GameObject.Instantiate(enemy);
            SetPosition(instantiateEnemy, SpawnPosition);
            return instantiateEnemy;
        }

        protected void SetPosition(Enemy enemy, Vector3 spawnPosition)
            => enemy.transform.position = spawnPosition;
    }
}