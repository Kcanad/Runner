using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _healths;

    public event UnityAction <int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        HealthChanged?.Invoke(_healths);
    }

    public void ApplyDamage(int damage)
    {
        _healths -= damage;
        HealthChanged?.Invoke(_healths);

        if (_healths <= 0)
        {
            Die();
        }

    }

    public void Die()
    {
        Died?.Invoke();
        
    }
}
