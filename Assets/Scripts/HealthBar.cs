using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private UnitHealth _unitHealth;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _delay;

    private void OnEnable()
    {
        _unitHealth.Changed += ChangeHealth;
    }

    private void OnDisable()
    {
        _unitHealth.Changed -= ChangeHealth;
    }

    private void ChangeHealth(int health)
    {
        float calculationHealth = (float)health / _unitHealth.MaxHealth;
        _slider.DOValue(calculationHealth, _delay);
    }
}
