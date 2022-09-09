using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Character _player;

    private int _healRate = 10;
    private int _damageRate = 10;

    private void Awake () {
        SetMaxHealth(_player.MaxHealth);
    }

    public void MakeDamage () {
        _player.TakeDamage(_damageRate);
        SetHealth(_player.CurrentHealth);
    }

    public void HealPlayer () {
        _player.Heal(_healRate);
        SetHealth(_player.CurrentHealth);
    }

    public void SetMaxHealth (int health) {
        _healthBar.maxValue = health;
        _healthBar.value = health;
    }

    public void SetHealth (int health) {
        _healthBar.DOValue(health, 1, true);
    }
}
