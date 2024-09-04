using UnityEngine;
using Task2.Enemys.EnemyType;

namespace Task2.Enemys.RaceType.Ork
{
    public class OrkPaladin : Paladin
    {
        public override void Attack()
        {
            Debug.Log("Священный удар орка-паладин");
        }
    }
}
