using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public class MagicianSpecialization : SpecializationStat
    {
        public MagicianSpecialization(IStatProvider statProvider, int multiplier) : 
            base(statProvider, multiplier) { }

        protected override Stat GetIntelligence()
            => base.GetIntelligence().Multiply(Multiplier);
    }
}