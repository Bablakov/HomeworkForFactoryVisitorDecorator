using UnityEngine;
using Task2.Enemys.EnemyType;

namespace Task2.Enemys.RaceType.Ork
{
    public class OrkMagician : Magician
    {
        public override void Attack()
        {
            Debug.Log("Магическая атака орка");
        }
    }
}
