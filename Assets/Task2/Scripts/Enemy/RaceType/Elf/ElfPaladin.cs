using Task2.Enemys.EnemyType;
using UnityEngine;

namespace Task2.Enemys.RaceType.Elf
{
    public class ElfPaladin : Paladin
    {
        public override void Attack()
        {
            Debug.Log("Священный удар ельфа-паладин");
        }
    }
}