using UnityEngine;

public class ButtonApplyDamage : MonoBehaviour
{
    [SerializeField] private int _damage;

    public void OnButton(UnitHealth unitHealth)
    {
        unitHealth.Health -= _damage;
    }
}
