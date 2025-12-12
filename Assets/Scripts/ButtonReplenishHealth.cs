using UnityEngine;
using UnityEngine.UI;

public class ButtonReplenishHealth : BaseButton
{
    [SerializeField] private UnitHealth _unitHealth;
    [SerializeField] private int _amountReplenishHealth;

    protected override void OnButton()
    {
        _unitHealth.Health += _amountReplenishHealth;
    }
}