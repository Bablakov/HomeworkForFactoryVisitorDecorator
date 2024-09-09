using Task5.Configs;
using Task5.Stats;

namespace Task5.StatProviders.Races
{
    public abstract class RaceStat : StatProvider
    {
        protected CharacterStat CharacterStat;

        public RaceStat(CharacterConfig characterConfig)
            => CharacterStat = new CharacterStat(characterConfig);

        protected override Stat GetDexterity()
            => CharacterStat.Dexterity;

        protected override Stat GetIntelligence()
            => CharacterStat.Intelligence;

        protected override Stat GetPower()
            => CharacterStat.Power;
    }
}