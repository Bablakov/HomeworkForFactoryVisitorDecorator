using Task5.Stats;

namespace Task5.StatProviders.Races
{
    public abstract class RaceStat : IStatProvider
    {
        protected CharacterStat CharacterStat;
        public abstract CharacterStat GetStat();
    }
}