using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Character : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    
    public event Action<float> OnHealthChanged;
    public int Health { get; private set; }

    private void Start() {
        Health = _maxHealth;
    }

    public void Heal (int healAmount) {
        Health += healAmount;
        Health = Mathf.Clamp(Health, 0, _maxHealth);
        OnHealthChanged.Invoke(GetHealthPercent());
    }

    public void TakeDamage(int damageAmount) {
        Health -= damageAmount;
        Health = Mathf.Clamp(Health, 0, _maxHealth);
        OnHealthChanged.Invoke(GetHealthPercent());
    }

    private float GetHealthPercent () {
        return (float)Health / _maxHealth;
    }
}
