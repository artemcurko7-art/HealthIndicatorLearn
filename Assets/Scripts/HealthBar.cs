using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
        StartCoroutine(Change(calculationHealth));
    }

    private IEnumerator Change(float calculationHealth)
    {
        while (enabled)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, calculationHealth, _delay * Time.deltaTime);

            if (_slider.value == calculationHealth)
                yield break;

            yield return null;
        }
    }
}
