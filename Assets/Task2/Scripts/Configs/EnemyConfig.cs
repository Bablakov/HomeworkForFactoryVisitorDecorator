using Task2.Enemys.RaceType.Elf;
using Task2.Enemys.RaceType.Ork;
using UnityEngine;

namespace Task2.Configs
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/EnemyConfig")]
    public class EnemyConfig : ScriptableObject
    {
        [field: SerializeField] public OrkMagician OrkMagician { get; private set; }
        [field: SerializeField] public ElfMagician ElfMagician { get; private set; }
        [field: SerializeField] public OrkPaladin OrkPaladin { get; private set; }
        [field: SerializeField] public ElfPaladin ElfPaladin { get; private set; }
    }
}