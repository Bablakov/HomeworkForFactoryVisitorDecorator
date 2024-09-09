using System;
using Task2.Configs;
using Task2.Enemys;
using Task2.Enums;
using UnityEngine;

namespace Task2.Factory
{
    public class OrkFactory : EnemyFactory
    {
        private OrkConfig _orkConfig;

        public OrkFactory(EnemyConfig enemyConfig)
            => _orkConfig = enemyConfig.OrkConfig;

        public override Enemy Get(EnemyType enemyType, Vector3 spawnPosition)
        {
            switch (enemyType)
            {
                case EnemyType.Paladin:
                    return CreateEnemy(_orkConfig.OrkPaladin, spawnPosition);

                case EnemyType.Magician:
                    return CreateEnemy(_orkConfig.OrkMagician, spawnPosition);

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}