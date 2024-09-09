using Task5.Stats;

namespace Task5.StatProviders.Races
{
    public class HumanRace : RaceStat
    {
        public HumanRace()
        {
            CharacterStat = new CharacterStat(2, 2, 2);
        }

        public override CharacterStat GetStat()
            => CharacterStat;
    }
}