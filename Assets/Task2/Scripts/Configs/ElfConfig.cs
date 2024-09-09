using System;
using Task2.Enemys.RaceType.Elf;
using UnityEngine;

namespace Task2.Configs
{
    [Serializable]
    public class ElfConfig
    {
        [field: SerializeField] public ElfMagician ElfMagician { get; private set; }
        [field: SerializeField] public ElfPaladin ElfPaladin { get; private set; }
    }
}