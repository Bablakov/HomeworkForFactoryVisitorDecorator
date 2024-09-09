using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public class ThiefSpecialization: SpecializationStat
    {
        public ThiefSpecialization(IStatProvider statProvider, int multiplier) : 
            base(statProvider, multiplier) { }

        protected override Stat GetDexterity()
            => base.GetDexterity().Multiply(Multiplier);
    }
}