using Zenject;
using UnityEngine;

namespace Task3.Configs
{
    [CreateAssetMenu(fileName = "GameConfigInstaller", menuName = "Configs/Task3/GameConfigInstaller")]
    public class GameConfigInstaller : ScriptableObjectInstaller<GameConfigInstaller>
    {
        [SerializeField] private CoinConfig _coinConfig;

        public override void InstallBindings()
        {
            Container.Bind<CoinConfig>().FromInstance(_coinConfig);
        }
    }
}