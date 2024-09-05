using UnityEngine;
using Zenject;

namespace Task2.Configs
{
    [CreateAssetMenu(fileName = "GameConfigInstaller", menuName = "Configs/Task2/Task2GameConfigInstaller")]
    public class GameConfigInstaller : ScriptableObjectInstaller<GameConfigInstaller>
    {
        //[SerializeField] private GameConfig _gameConfig;
        [SerializeField] private EnemyConfig _enemyConfig;

        public override void InstallBindings()
        {
            //Container.Bind<GameConfig>().FromInstance(_gameConfig);
            Container.Bind<EnemyConfig>().FromInstance(_enemyConfig);
        }
    }
}