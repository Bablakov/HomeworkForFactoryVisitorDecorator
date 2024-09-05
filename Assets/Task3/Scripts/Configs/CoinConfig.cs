using Task3.Coins;
using UnityEngine;

namespace Task3.Configs
{
    [CreateAssetMenu(fileName = "CoinConfig", menuName = "Configs/Task3/CoinConfig")]
    public class CoinConfig : ScriptableObject
    {
        [field: SerializeField] public EmptyCoin EmptyCoin { get; private set; }
        [field: SerializeField] public RandomCoin RandomCoin { get; private set; }
        [field: SerializeField] public StandartCoin StandartCoin { get; private set; }

    }
}