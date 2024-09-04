using Task2.Enemys;
using Task2.Enums;

namespace Task2.Factory
{
    public abstract class EnemyFactory
    {
        public abstract Enemy Get(EnemyType enemyType);
    }
}