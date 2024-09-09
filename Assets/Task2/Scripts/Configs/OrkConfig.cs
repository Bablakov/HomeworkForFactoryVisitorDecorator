using System;
using Task2.Enemys.RaceType.Ork;
using UnityEngine;

namespace Task2.Configs
{
    [Serializable]
    public class OrkConfig
    {
        [field: SerializeField] public OrkMagician OrkMagician { get; private set; }
        [field: SerializeField] public OrkPaladin OrkPaladin { get; private set; }
    }
}