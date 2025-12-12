using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private UnitHealth _unitHealth;
    [SerializeField] private TMP_Text _currentHealthtext;
    [SerializeField] private TMP_Text _maxHealthText;

    private void Start()
    {
        _currentHealthtext.text = _unitHealth.MaxHealth.ToString();
        _maxHealthText.text = _unitHealth.MaxHealth.ToString();
    }

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
        _currentHealthtext.text = health.ToString();
    }
}
