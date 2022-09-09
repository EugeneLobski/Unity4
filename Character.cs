using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int MaxHealth { get; private set; } = 100;

    public int CurrentHealth { get; private set; }

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void Heal (int healRate) {
        if (CurrentHealth < 100)
            CurrentHealth += healRate;
    }

    public void TakeDamage(int dagame) {
        if (CurrentHealth > 0)
            CurrentHealth -= dagame;
    }
}
