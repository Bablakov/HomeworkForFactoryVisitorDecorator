using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public class MagicianSpecialization : SpecializationStat
    {
        public MagicianSpecialization(IStatProvider statProvider) : base(statProvider) { }

        public override CharacterStat GetStat()
        {
            var stats = StatProvider.GetStat();

            var statsNew = new CharacterStat(stats.DexterityStat.Value,
                stats.IntelligenceStat.Value * 2, stats.PowerStat.Value);
                
            return statsNew;
        }
    }
}