using Task5.Enums;
using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public abstract class SpecializationStat : StatProvider
    {
        protected int Multiplier;
        protected IStatProvider StatProvider;

        public SpecializationStat(IStatProvider statProvider, int multiplier)
        {
            StatProvider = statProvider;
            Multiplier = multiplier;
        }

        protected override Stat GetDexterity()
            => StatProvider.GetStat(StatType.Dexterity);

        protected override Stat GetIntelligence() 
            => StatProvider.GetStat(StatType.Intelligence);

        protected override Stat GetPower()
            => StatProvider.GetStat(StatType.Power);
    }
}