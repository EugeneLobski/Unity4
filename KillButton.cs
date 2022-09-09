using UnityEngine;

public class KillButton : MonoBehaviour
{
    [SerializeField] private int _damageAmount = 10;
    [SerializeField] private Character _target;

    public void MakeDamage () {
        _target.TakeDamage(_damageAmount);
    }
}
