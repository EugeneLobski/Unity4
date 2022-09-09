using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Character _character;

    private void Start () {
        _character.OnHealthChanged += ChangeBar;
    }

    private void ChangeBar (float health) {
        transform.DOScaleX(health, 1);
    }
}
