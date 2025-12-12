using System;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    [SerializeField] private int _health;

    public event Action<int> Changed;

    public int MaxHealth { get; private set; }

    public int Health
    {
        get => _health;

        set
        {
            _health = Mathf.Clamp(value, 0, MaxHealth);
            Changed?.Invoke(_health);
        }
    }

    private void Awake()
    {
        MaxHealth = _health;
    }
}
