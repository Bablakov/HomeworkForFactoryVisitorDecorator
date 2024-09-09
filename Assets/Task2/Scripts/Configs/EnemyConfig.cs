using UnityEngine;

namespace Task2.Configs
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/Task2/EnemyConfig")]
    public class EnemyConfig : ScriptableObject
    {
        [field: SerializeField] public ElfConfig ElfConfig { get; private set; }
        [field: SerializeField] public OrkConfig OrkConfig { get; private set; }
    }
}