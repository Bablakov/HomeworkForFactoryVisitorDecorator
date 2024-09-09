using Task5.Enums;
using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public abstract class PassiveAbility : StatProvider
    {
        protected int Supplement;
        protected IStatProvider StatProvider;

        public PassiveAbility(IStatProvider statProvider, int supplement)
        {
            StatProvider = statProvider;
            Supplement = supplement;
        }

        protected override Stat GetDexterity()
            => StatProvider.GetStat(StatType.Dexterity);

        protected override Stat GetIntelligence()
            => StatProvider.GetStat(StatType.Intelligence);

        protected override Stat GetPower()
            => StatProvider.GetStat(StatType.Power);
    }
}