using UnityEngine;

public class ButtonReplenishHealth : MonoBehaviour
{
    [SerializeField] private int _amountReplenishHealth;

    public void OnButton(UnitHealth unitHealth)
    {
        unitHealth.Health += _amountReplenishHealth;
    }
}
