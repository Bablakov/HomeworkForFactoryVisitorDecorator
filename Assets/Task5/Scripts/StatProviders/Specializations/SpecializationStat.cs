using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public abstract class SpecializationStat : IStatProvider 
    {
        protected IStatProvider StatProvider;

        public SpecializationStat(IStatProvider statProvider)
            => StatProvider = statProvider;

        public abstract CharacterStat GetStat();
    }
}