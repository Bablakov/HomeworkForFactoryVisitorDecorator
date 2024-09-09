using System;
using UnityEngine;

namespace Assets.Task5.Scripts.Configs
{
    [CreateAssetMenu(fileName = "new SpecializationConfig", menuName = "Configs/Task5/SpecializationConfig")]
    public class SpecializationConfig : ScriptableObject
    {
        [field: SerializeField, Range(0, 10)] public int Barbarian { get; private set; }
        [field: SerializeField, Range(0, 10)] public int Magician { get; private set; }
        [field: SerializeField, Range(0, 10)] public int Thief { get; private set; }
    }
}