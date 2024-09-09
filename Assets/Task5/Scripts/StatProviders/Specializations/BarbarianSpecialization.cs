using Task5.Stats;

namespace Task5.StatProviders.Specializations
{
    public class BarbarianSpecialization : SpecializationStat
    {
        public BarbarianSpecialization(IStatProvider statProvider, int multiplier) : 
            base(statProvider, multiplier) { }

        protected override Stat GetPower()
            => base.GetPower().Multiply(Multiplier);
    }
}