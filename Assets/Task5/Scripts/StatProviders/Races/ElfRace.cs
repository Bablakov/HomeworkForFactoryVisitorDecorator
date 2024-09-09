using Task5.Stats;

namespace Task5.StatProviders.Races
{
    public class ElfRace : RaceStat
    {
        public ElfRace()
        {
            CharacterStat = new CharacterStat(1, 3, 1);
        }

        public override CharacterStat GetStat()
            => CharacterStat;
    }
}