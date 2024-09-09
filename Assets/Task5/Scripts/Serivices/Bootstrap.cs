using Task5.StatProviders;
using Task5.StatProviders.PassiveAbilities;
using Task5.StatProviders.Races;
using Task5.StatProviders.Specializations;
using UnityEngine;

namespace Task5.Serivices
{
    public class Bootstrap : MonoBehaviour
    {
        private IStatProvider _humanStatProvider;
        private IStatProvider _orkStatProvider;
        private IStatProvider _elfStatProvider;

        private void Awake()
        {
            _humanStatProvider = new JockPassiveAbility(new BarbarianSpecialization(new HumanRace()));
            _orkStatProvider = new SmartAbility(new MagicianSpecialization(new OrkRace()));
            _elfStatProvider = new NiblePassiveAbility(new ThiefSpecialization(new ElfRace()));

            OutputInfo(_humanStatProvider, "Human");
            OutputInfo(_orkStatProvider, "Ork");
            OutputInfo(_elfStatProvider, "Elf");
        }

        private void OutputInfo(IStatProvider statProvider, string name)
        {
            var stat = statProvider.GetStat();
            Debug.Log($"Name - {name}, Stats : DexterityStat - {stat.DexterityStat.Value}, " +
                $"intelligenceStat - {stat.IntelligenceStat.Value}, powerStat - {stat.PowerStat.Value}");
        }
    }
}