using Task3.Interfaces;
using UnityEngine;

public class Player : MonoBehaviour, ICoinPicker
{
    public int Coins { get; private set; }

    public void Add(int value)
    {
        //проверяем value

        Coins += value;
        Debug.Log(Coins);
    }
}
