using System;
using Task2.Enums;
using Task2.Factory;
using Zenject;

namespace Assets.Task2.Scripts.Factory
{
    public class FactoryEnemyFactory
    {
        private IInstantiator _instantiator;

        public FactoryEnemyFactory(IInstantiator instantiator) =>
            _instantiator = instantiator;

        public EnemyFactory Create(EnemyRace typeFactory)
        {
            switch (typeFactory)
            {
                case EnemyRace.Elf:
                    return _instantiator.Instantiate<ElfFactory>();
                case EnemyRace.Ork:
                    return _instantiator.Instantiate<OrkFactory>();

                default:
                    throw new ArgumentException(nameof(typeFactory));
            }
        }
    }
}