using System;
using UnityEngine;

namespace Task3.Interfaces
{
    public interface IDestroyed
    {
        public event Action Destroyed;

        public Transform Transform { get; }
    }
}