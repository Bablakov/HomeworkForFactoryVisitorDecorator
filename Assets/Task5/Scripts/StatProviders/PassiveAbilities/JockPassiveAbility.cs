using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public class JockPassiveAbility : PassiveAbility
    {
        public JockPassiveAbility(IStatProvider statProvider) : base(statProvider) { }

        public override CharacterStat GetStat()
        {
            var stats = StatProvider.GetStat();

            var statsNew = new CharacterStat(stats.DexterityStat.Value,
                stats.IntelligenceStat.Value, stats.PowerStat.Value + 10);

            return statsNew;
        }
    }
}