using System;
using Task2.Configs;
using Task2.Enemys;
using Task2.Enums;
using UnityEngine;

namespace Task2.Factory
{
    public class ElfFactory : EnemyFactory
    {
        private ElfConfig _elfConfig;

        public ElfFactory(EnemyConfig enemyConfig)
            => _elfConfig = enemyConfig.ElfConfig;

        public override Enemy Get(EnemyType enemyType, Vector3 spawnPosition)
        {
            switch (enemyType)
            {
                case EnemyType.Paladin:
                    return CreateEnemy(_elfConfig.ElfMagician, spawnPosition);

                case EnemyType.Magician:
                    return CreateEnemy(_elfConfig.ElfMagician, spawnPosition);

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}