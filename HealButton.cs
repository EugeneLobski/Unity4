using UnityEngine;


public class HealButton : MonoBehaviour
{
    [SerializeField] private int _healAmount = 10;
    [SerializeField] private Character _target;

    public void Heal () {
        _target.Heal(_healAmount);
    }
}
