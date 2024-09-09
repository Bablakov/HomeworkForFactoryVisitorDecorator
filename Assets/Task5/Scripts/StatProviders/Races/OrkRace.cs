using Task5.Stats;

namespace Task5.StatProviders.Races
{
    public class OrkRace : RaceStat
    {
        public OrkRace()
        {
            CharacterStat = new CharacterStat(1, 1, 3);
        }

        public override CharacterStat GetStat()
            => CharacterStat;
    }
}