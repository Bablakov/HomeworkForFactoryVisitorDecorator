namespace Task5.Stats
{
    public class CharacterStat
    {
        public DexterityStat DexterityStat { get; set; }
        public IntelligenceStat IntelligenceStat { get; set; }
        public PowerStat PowerStat { get; set; }

        public CharacterStat(int dexterity, int intelligence, int power)
        {
            DexterityStat = new DexterityStat(dexterity);
            IntelligenceStat = new IntelligenceStat(intelligence);
            PowerStat = new PowerStat(power);
        }
    }
}