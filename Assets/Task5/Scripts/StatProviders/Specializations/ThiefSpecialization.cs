using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public class ThiefSpecialization: SpecializationStat
    {
        public ThiefSpecialization(IStatProvider statProvider) : base(statProvider) { }

        public override CharacterStat GetStat()
        {
            var stats = StatProvider.GetStat();

            var statsNew = new CharacterStat(stats.DexterityStat.Value * 2,
                stats.IntelligenceStat.Value, stats.PowerStat.Value);

            return statsNew;
        }
    }
}