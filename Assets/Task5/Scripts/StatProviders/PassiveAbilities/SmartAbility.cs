using System;
using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public class SmartAbility : PassiveAbility
    {
        public SmartAbility(IStatProvider statProvider) : base(statProvider) { }

        public override CharacterStat GetStat()
        {
            var stats = StatProvider.GetStat();

            var statsNew = new CharacterStat(stats.DexterityStat.Value,
                stats.IntelligenceStat.Value + 10, stats.PowerStat.Value);

            return statsNew;
        }
    }
}