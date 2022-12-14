using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Character _character;

    private void OnEnable () {
        _character.HealthChanged += ChangeBar;
    }

    private void OnDisable () {
        _character.HealthChanged -= ChangeBar;
    }

    private void ChangeBar (float health) {
        float duration = 1f;
        transform.DOScaleX(health, duration);
    }
}
