using UnityEngine;

public class ButtonApplyDamage : BaseButton
{
    [SerializeField] private UnitHealth _unitHealth;
    [SerializeField] private int _damage;

    protected override void OnButton()
    {
        _unitHealth.Health -= _damage;
    }
}
