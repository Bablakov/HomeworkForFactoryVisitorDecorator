using Task3.Input;
using Task3.Interfaces;
using UnityEngine;
using Zenject;

namespace Task3
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour, ICoinPicker, IInitializable
    {
        [SerializeField, Range(0, 10)] private float _speed;

        private GameInput _gameInput;
        private CharacterController _characterController;

        public int Coins { get; private set; }

        [Inject]
        public void Construct(GameInput gameInput)
            => _gameInput = gameInput;

        public void Initialize()
            => _characterController = GetComponent<CharacterController>();

        private void Update()
        {
            if (_gameInput.CanMovement)
                _characterController.Move(_gameInput.GetDirectionMovememt() * _speed * Time.deltaTime);
        }

        public void Add(int value)
        {
            if (value > 0)
            {
                Coins += value;
                Debug.Log(Coins);
            }
        }
    }
}