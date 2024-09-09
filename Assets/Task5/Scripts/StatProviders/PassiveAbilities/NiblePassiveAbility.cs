using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public class NiblePassiveAbility : PassiveAbility
    {
        public NiblePassiveAbility(IStatProvider statProvider) : base(statProvider) { }

        public override CharacterStat GetStat()
        {
            var stats = StatProvider.GetStat();

            var statsNew = new CharacterStat(stats.DexterityStat.Value + 10,
                stats.IntelligenceStat.Value, stats.PowerStat.Value);

            return statsNew;
        }
    }
}