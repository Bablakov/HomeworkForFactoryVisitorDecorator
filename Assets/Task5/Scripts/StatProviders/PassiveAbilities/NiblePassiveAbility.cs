using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public class NiblePassiveAbility : PassiveAbility
    {
        public NiblePassiveAbility(IStatProvider statProvider, int supplement) :
            base(statProvider, supplement)
        { }

        protected override Stat GetPower()
            => base.GetDexterity().Add(Supplement);
    }
}