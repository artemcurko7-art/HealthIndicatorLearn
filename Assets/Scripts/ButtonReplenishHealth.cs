using UnityEngine;

public class ButtonReplenishHealth : MonoBehaviour
{
    [SerializeField] private UnitHealth _unitHealth;
    [SerializeField] private int _amountReplenishHealth;

    public void OnButton() =>
        _unitHealth.Health += _amountReplenishHealth;
}
