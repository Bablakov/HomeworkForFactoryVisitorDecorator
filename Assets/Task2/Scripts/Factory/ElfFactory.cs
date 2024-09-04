using System;
using Task2.Enemys;
using Task2.Enemys.RaceType.Elf;
using Task2.Enums;
using UnityEngine;

namespace Task2.Factory
{
    public class ElfFactory : EnemyFactory
    {
        private ElfPaladin _elfPaladin;
        private ElfMagician _elfMagician;

        public ElfFactory(ElfPaladin elfPaladin, ElfMagician elfMagician) 
        { 
            _elfPaladin = elfPaladin;
            _elfMagician = elfMagician;
        }

        public override Enemy Get(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Paladin:
                    return GameObject.Instantiate(_elfPaladin);

                case EnemyType.Magician:
                    return GameObject.Instantiate(_elfMagician);

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}