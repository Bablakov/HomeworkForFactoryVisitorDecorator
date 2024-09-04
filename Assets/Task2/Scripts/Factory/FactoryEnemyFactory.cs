using Task2.Factory;
using Zenject;

namespace Assets.Task2.Scripts.Factory
{
    public class FactoryEnemyFactory
    {
        private IInstantiator _instantiator;

        public FactoryEnemyFactory(IInstantiator instantiator) =>
            _instantiator = instantiator;

        public TFactory Create<TFactory>() where TFactory : EnemyFactory =>
            _instantiator.Instantiate<TFactory>();
    }
}