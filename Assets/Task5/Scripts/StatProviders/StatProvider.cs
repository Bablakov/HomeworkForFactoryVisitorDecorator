using System;
using Task5.Enums;
using Task5.Stats;

namespace Task5.StatProviders
{
    public abstract class StatProvider : IStatProvider
    {
        public Stat GetStat(StatType statType)
        {
            switch (statType)
            {
                case StatType.Dexterity:
                    return GetDexterity();

                case StatType.Intelligence:
                    return GetIntelligence();

                case StatType.Power:
                    return GetPower();

                default:
                    throw new ArgumentException();
            }
        }

        protected abstract Stat GetDexterity();
        protected abstract Stat GetIntelligence();
        protected abstract Stat GetPower();
    }
}