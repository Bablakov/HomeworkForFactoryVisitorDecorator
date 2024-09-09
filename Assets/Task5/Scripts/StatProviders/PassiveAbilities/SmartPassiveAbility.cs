using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public class SmartPassiveAbility : PassiveAbility
    {
        public SmartPassiveAbility(IStatProvider statProvider, int supplement) :
            base(statProvider, supplement)
        { }

        protected override Stat GetPower()
            => base.GetIntelligence().Add(Supplement);
    }
}