using UnityEngine;
using Task2.Enemys.EnemyType;

namespace Task2.Enemys.RaceType.Elf
{
    public class ElfMagician : Magician
    {
        public override void Attack()
        {
            Debug.Log("Магическая атака ельфа");
        }
    }
}