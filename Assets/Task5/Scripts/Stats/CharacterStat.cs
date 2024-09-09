using Task5.Configs;

namespace Task5.Stats
{
    public class CharacterStat
    {
        public DexterityStat Dexterity { get; set; }
        public IntelligenceStat Intelligence { get; set; }
        public PowerStat Power { get; set; }

        public CharacterStat(int dexterity, int intelligence, int power)
        {
            Dexterity = new DexterityStat(dexterity);
            Intelligence = new IntelligenceStat(intelligence);
            Power = new PowerStat(power);
        }

        public CharacterStat(CharacterConfig characterConfig)
            : this(characterConfig.Dexterity, characterConfig.Intelligence, characterConfig.Power) 
        { }
    }
}