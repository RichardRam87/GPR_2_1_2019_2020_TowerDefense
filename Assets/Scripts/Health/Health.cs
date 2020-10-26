using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [Serializable]
    public class OnTakeDamageEvent : UnityEvent<Health> {}
    [Serializable]
    public class OnDeathEvent : UnityEvent<Health> {}

    public OnTakeDamageEvent OnTakeDamage;
    public OnDeathEvent OnDeath;
    [SerializeField] private float _startHealth = 3;

    private float _currentHealth;
    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    // Called from UnityEvent
    public void TakeDamage(float dmg = 1f)
    {
        _currentHealth -= dmg;
        OnTakeDamage?.Invoke(this);
        
        if (_currentHealth <= 0)
        {
            print("Ik ben dood");
            OnDeath?.Invoke(this);
        }
    }
}
