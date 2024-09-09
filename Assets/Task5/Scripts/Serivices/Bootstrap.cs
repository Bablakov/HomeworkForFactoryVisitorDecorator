using Assets.Task5.Scripts.Configs;
using Assets.Task5.Scripts.Serivices;
using System.Collections.Generic;
using Task5.Configs;
using Task5.Enums;
using Task5.StatProviders;
using Task5.StatProviders.PassiveAbilities;
using Task5.StatProviders.Races;
using Task5.StatProviders.Specializations;
using UnityEngine;

namespace Task5.Serivices
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _humanConfig;
        [SerializeField] private CharacterConfig _orkConfig;
        [SerializeField] private CharacterConfig _elfConfig;

        [SerializeField] private PassiveAbilityConfig _passiveAbilityConfig;
        [SerializeField] private SpecializationConfig _specializationConfig;

        private IStatProvider _humanStatProvider;
        private IStatProvider _orkStatProvider;
        private IStatProvider _elfStatProvider;

        private List<IStatProvider> _statProviders;

        private StatProvidersController _statProvidersController;

        private void Awake()
        {
            _humanStatProvider = new JockPassiveAbility(new BarbarianSpecialization(new HumanRace(_humanConfig), _specializationConfig.Barbarian), _passiveAbilityConfig.Jock);
            _orkStatProvider = new SmartPassiveAbility(new MagicianSpecialization(new OrkRace(_orkConfig), _specializationConfig.Magician), _passiveAbilityConfig.Smart);
            _elfStatProvider = new NiblePassiveAbility(new ThiefSpecialization(new ElfRace(_elfConfig), _specializationConfig.Thief), _passiveAbilityConfig.Nible);

            _statProviders = new List<IStatProvider>();

            _statProviders.Add(_humanStatProvider);
            _statProviders.Add(_orkStatProvider);
            _statProviders.Add(_elfStatProvider);

            _statProvidersController = new StatProvidersController(_statProviders);
        }
    }
}