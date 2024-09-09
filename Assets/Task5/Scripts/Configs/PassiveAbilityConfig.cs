using System;
using UnityEngine;

namespace Task5.Configs
{
    [CreateAssetMenu(fileName = "new PassiveAbilityConfig", menuName = "Configs/Task5/PassiveAbilityConfig")]
    public class PassiveAbilityConfig : ScriptableObject
    {
        [field: SerializeField, Range(0, 10)] public int Jock { get; private set; }
        [field: SerializeField, Range(0, 10)] public int Nible { get; private set; }
        [field: SerializeField, Range(0, 10)] public int Smart { get; private set; }
    }
}