using System;
using UnityEngine;

namespace Task5.Configs
{
    [CreateAssetMenu(fileName = "new CharacterConfig", menuName = "Configs/Task5/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [field: SerializeField, Range(0, 10)] public int Dexterity { get; private set; }
        [field: SerializeField, Range(0, 10)] public int Intelligence { get; private set; }
        [field: SerializeField, Range(0, 10)] public int Power { get; private set; }
    }
}
