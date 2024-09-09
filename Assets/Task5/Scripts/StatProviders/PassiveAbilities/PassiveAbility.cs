using Task5.Stats;

namespace Task5.StatProviders.PassiveAbilities
{
    public abstract class PassiveAbility : IStatProvider
    {
        protected IStatProvider StatProvider;

        public PassiveAbility(IStatProvider statProvider)
            => StatProvider = statProvider;

        public abstract CharacterStat GetStat();
    }
}