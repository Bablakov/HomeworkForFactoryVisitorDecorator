using UnityEngine;
using Zenject;

namespace Task2.Configs
{
    [CreateAssetMenu(fileName = "GameConfigInstaller", menuName = "Configs/Task2/GameConfigInstaller")]
    public class GameConfigInstaller : ScriptableObjectInstaller<GameConfigInstaller>
    {
        [SerializeField] private EnemyConfig _enemyConfig;

        public override void InstallBindings()
            => Container.Bind<EnemyConfig>().FromInstance(_enemyConfig);
    }
}