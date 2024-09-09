using Task5.Enums;
using Task5.Stats;

namespace Task5.StatProviders
{
    public interface IStatProvider
    {
        public Stat GetStat(StatType statType);
    }
}