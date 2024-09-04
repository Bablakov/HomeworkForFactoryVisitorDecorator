using System;
using Task2.Enemys;
using Task2.Enemys.RaceType.Ork;
using Task2.Enums;
using UnityEngine;

namespace Task2.Factory
{
    public class OrkFactory : EnemyFactory
    {
        private OrkPaladin _orkPaladin;
        private OrkMagician _orkMagician;

        public OrkFactory(OrkPaladin orkPaladin, OrkMagician orkMagician) 
        { 
            _orkPaladin = orkPaladin;
            _orkMagician = orkMagician;
        }

        public override Enemy Get(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Paladin:
                    return GameObject.Instantiate(_orkPaladin);

                case EnemyType.Magician:
                    return GameObject.Instantiate(_orkMagician);

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}