using UnityEngine;

public class ButtonApplyDamage : MonoBehaviour
{
    [SerializeField] private UnitHealth _unitHealth;
    [SerializeField] private int _damage;

    public void OnButton() =>
        _unitHealth.Health -= _damage;
}
