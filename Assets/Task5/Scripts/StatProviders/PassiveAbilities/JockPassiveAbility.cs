using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public class JockPassiveAbility : PassiveAbility
    {
        public JockPassiveAbility(IStatProvider statProvider, int supplement) :
            base(statProvider, supplement)
        { }

        protected override Stat GetPower()
            => base.GetPower().Add(Supplement);
    }
}