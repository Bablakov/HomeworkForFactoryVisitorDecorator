using System.Collections.Generic;
using UnityEngine;
using Task5.Enums;
using Task5.StatProviders;

namespace Assets.Task5.Scripts.Serivices
{
    public class StatProvidersController
    {
        private List<IStatProvider> _statProviders;

        public StatProvidersController(IEnumerable<IStatProvider> statProviders)
        {
            _statProviders = new List<IStatProvider>(statProviders);

            foreach (var statProvider in _statProviders)
                OutputInformation(statProvider);
        }

        private void OutputInformation(IStatProvider statProvider)
        {
            Debug.Log($"Name - {nameof(statProvider)}, Stats : " +
                $"DexterityStat - {statProvider.GetStat(StatType.Dexterity).Value}, " +
                $"intelligenceStat - {statProvider.GetStat(StatType.Intelligence).Value}, " +
                $"powerStat - {statProvider.GetStat(StatType.Power).Value}");
        }
    }
}