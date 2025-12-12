using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    protected abstract void OnButton();

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButton);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButton);
    }
}
